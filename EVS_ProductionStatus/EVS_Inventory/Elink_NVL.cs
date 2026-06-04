using EVS_ProductionStatus.Update_Inventory.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;
using static System.Windows.Forms.LinkLabel;
using EVS_ProductionStatus.Update_Inventory.Model;
using EVS_ProductionStatus.Data;

//http://172.31.9.31/test_api/
//https://localhost:7188/

namespace EVS_ProductionStatus
{
    public partial class Elink_NVL : Form
    {
        private readonly Product_Eink _item;
        string tt_connect = ""; // Thông tin connect_string
        public Elink_NVL(Product_Eink item, string tt)
        {
            InitializeComponent();
            _item = item ?? throw new ArgumentNullException(nameof(item)); // lấy thông tin từ formRM_WIP sang
            tt_connect = tt;
        }


        private static readonly HttpClient http = InitializeClient();

        private static HttpClient InitializeClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://172.31.9.31/test_api/"),
                Timeout = TimeSpan.FromSeconds(100)
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        private async Task<string> Get_IDItem(string endpoint) //  lấy giá  trị id  được sinnh ra trong bảng tblproduct
        {
            try
            {

                var resp = await http.GetAsync(endpoint);
                var body = await resp.Content.ReadAsStringAsync();

                if (!resp.IsSuccessStatusCode)
                {
                    // Hiển thị thông báo từ API nếu có
                    MessageBox.Show($"{body}");
                    return null;
                }
                // Nếu thành công, hiển thị variant
                var resultString = JsonSerializer.Deserialize<string>(body);
                return resultString ?? body.Trim('"');
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return null;
            }
        }
        private async Task<Get_Link> Get_Link(string endpoint) // Lấy Thông tin mac,variant của link dựa vào id của  tblproduct
        {
            try
            {

                var resp = await http.GetAsync(endpoint);
                var body = await resp.Content.ReadAsStringAsync();

                if (!resp.IsSuccessStatusCode)
                {
                    // Hiển thị thông báo từ API nếu có
                    MessageBox.Show($"{body}");
                    return null;
                }
                // Nếu thành công, hiển thị variant

                var result = JsonSerializer.Deserialize<Get_Link>(body, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // không phân biệt hoa thường khóa JSON
                });

                return result;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return null;
            }
        }
        private async Task<string> GetDataAsync(string endpoint) //Lấy giá trị variant dựa vào mac của thẻ eink thông qua bảng labelstatus
        {
            try
            {
                var resp = await http.GetAsync(endpoint);
                var body = await resp.Content.ReadAsStringAsync();

                if (resp.StatusCode == HttpStatusCode.NoContent)
                    return null;
                if (!resp.IsSuccessStatusCode)
                {
                    return null;
                }
                return string.IsNullOrWhiteSpace(body) ? null : body;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return null;
            }
        }

        private async Task<string> PostDataAsync(string endpoint, object infor) // Thêm thông tin product rồi trả về giastrij id vừa tạo
        {

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(infor, options);
            using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage resp;
                try
                {
                    resp = await http.PostAsync(endpoint, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không gọi được API: {ex.Message}");
                    return null;
                }

                var body = await resp.Content.ReadAsStringAsync();
                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"POST thất bại\nEndpoint: {endpoint}\nStatus: {(int)resp.StatusCode} {resp.StatusCode}\nRequest JSON:\n{json}\nResponse:\n{body}");
                    return null;
                }
                return body.Trim().Trim('"');
            }
        }
        private async Task<bool> PostDataLink<T>(string endpoint, object infor) // thêm thông tin link rồi trả về kết quả nó đã thêm thành công hay chưa
        {

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(infor, options);
            using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage resp;
                try
                {
                    resp = await http.PostAsync(endpoint, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không gọi được API: {ex.Message}");
                    return false;
                }

                var body = await resp.Content.ReadAsStringAsync();

                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Xử lý thất bại \nLỗi: {body}");
                    return false;
                }
                return true;
            }
            
        }
        private async Task<bool> DeleteItemAsync(string endpointBase, string id) //Xóa thông tin
        {
            try
            {

                // endpointBase ví dụ: "api/product" hoặc "api/products"
                var url = $"{endpointBase}/{Uri.EscapeDataString(id)}";

                // Muốn timeout riêng:
                using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)))
                {
                    var res = await http.DeleteAsync(url, cts.Token);

                    if (res.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        // 204: Xóa thành công
                        return true;
                    }

                    else if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        var body = await res.Content.ReadAsStringAsync();
                        MessageBox.Show(string.IsNullOrWhiteSpace(body)
                            ? "Không tìm thấy bản ghi cần xóa."
                            : $"{body}");
                        return false;
                    }

                    else if (res.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        var body = await res.Content.ReadAsStringAsync();
                        MessageBox.Show(string.IsNullOrWhiteSpace(body)
                            ? "Yêu cầu không hợp lệ (400)."
                            : $"Yêu cầu không hợp lệ: {body}");
                        return false;
                    }

                    else
                    {
                        var body = await res.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi khi xóa (HTTP {(int)res.StatusCode}): {res.StatusCode}\n{body}");
                        return false;
                    }

                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Hết thời gian chờ khi gọi API xóa.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }
        private async void Connect_Load()
        {
            string value1 = _item.ItemCode.ToString();
            string value2 = _item.LotNo.ToString();
            var id = await Get_IDItem($"api/product/{value1}/{value2}");
            var result2 = await Get_Link($"api/link/by-id/{id}");

            txt_MAC.Text = result2.MAC;
            txt_Variant.Text = result2.Variant;
            txt_MAC.Enabled = false;
            lab_card_eink.Text = "Quét mã thẻ (Đã đăng ký)";
        }
        private void Load_data()
        {
            txt_Itemcode.Text = _item.ItemCode.ToString();
            txt_Lotno.Text = _item.LotNo.ToString();
            txt_Qty.Text = _item.R_float1.ToString();
            txt_Qty_allocate.Text = _item.R_float2.ToString();
            if(tt_connect == "Connect") // Nếu connect_string là "Connect" thì thực hiện việc load thông tin lên
            {
                Connect_Load();
            }
        }


        // Xử lý sự kiện

        private void Elink_NVL_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        //Lấy thông tin Variant và kiểm tra Mac của thẻ Eink
        private async void txt_get_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string value = txt_MAC.Text;
                var link_mac = await GetDataAsync($"api/labelstatus/{value}");
                //Kiểm tra xem thẻ eink có tồn tại không
                if (link_mac == null || string.IsNullOrWhiteSpace(txt_MAC.Text))
                {
                    MessageBox.Show("Thông tin MAC của thẻ Eink không thỏa mãn!");
                    return;
                }
                txt_Variant.Text = link_mac;
            }
        }
        private async void btn_connect_Click(object sender, EventArgs e)
        {
            //Kiểm tra khoảng trống ở các ô nhập
            if( String.IsNullOrEmpty(txt_MAC.Text))
            {
                MessageBox.Show("Mời bạn nhập MAC!");
            }else if(String.IsNullOrEmpty(txt_Variant.Text) )
            {
                MessageBox.Show("Chưa có giá trị Variant!");
            }
            else
            {
                //Nếu sản phẩm đã được kết nối thì hiện ra thông báo
                if(tt_connect == "Connect")
                {
                    MessageBox.Show("Sản phẩm đã được kết nối!");
                    return;
                }
                string value_mac =  txt_MAC.Text;

                //Kiểm tra thông tin mac của thẻ có chính xác không
                var link_mac = await GetDataAsync($"api/labelstatus/{value_mac}");
                if (link_mac == null)
                {
                    MessageBox.Show("Thông tin MAC của thẻ Eink không thỏa mãn!");
                    return;
                }

                //Kiểm tra thẻ Eink đã được sử  dụng hay chưa
                var check_connect = await GetDataAsync($"api/link/by-mac/{value_mac}");
                if( check_connect == null )
                {
                    //Ở đây có thể không cần tạo product nhưng tôi cứ viết cho chắc  trong trường hợp cần phải tạo product
                    var newProduct = new Product_Eink
                    {
                        ItemCode = _item.ItemCode,
                        LotNo = _item.LotNo,
                        R_float1 = _item.R_float1,
                        R_float2 = _item.R_float2,
                    };
                    // Nếu sản phẩm đã tồn tại thì sẽ chỉ trả lại giá trị id của product đó, nếu chưa thì sẽ tạo product
                    var newIdStr = await PostDataAsync("api/product", newProduct);
                    if (string.IsNullOrWhiteSpace(newIdStr))
                    {
                        MessageBox.Show("Tạo thất bại hoặc không nhận được ID.");
                        return;
                    }
                    var newLink = new Link_Eink
                    {
                        ID = newIdStr.ToString(),
                        Variant = txt_Variant.Text.ToString(),
                        MAC = txt_MAC.Text.ToString(),
                    };
                    var ok = await PostDataLink<Link_Eink>("api/link", newLink);
                    if (ok)
                    {
                        MessageBox.Show($"Kết nối thành công!");

                        using (var db = new Manage_evsEntities(clConnection.connectString2))
                        {
                            var product = db.NewInventory_EVS
                                .FirstOrDefault(p => p.Itemcode == _item.ItemCode && p.LotNo == _item.LotNo && p.Qty == _item.R_float1 && p.Qty_Allocate == _item.R_float2);

                            if (product != null)
                            {
                                product.connect_status = "Connect";
                                db.SaveChanges();
                            }
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Thẻ Elink đã được sử dụng!");
                    return;
                }
            }
        }

        private async void btn_un_connect_Click(object sender, EventArgs e)
        {
            if(tt_connect != "Connect")
            {
                MessageBox.Show("Chưa được kết nối!");
                return;
            }
            string message = "Bạn có chắc muốn hủy kết nối!";
            string caption = "Xác nhận xóa!";
            var result = MessageBox.Show(
                message,caption, MessageBoxButtons.YesNo,MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {

                var MAC_link = txt_MAC.Text.ToString();
                var ok2 = await DeleteItemAsync($"api/link", MAC_link);
                if (ok2)
                {
                    MessageBox.Show("Hủy kết nối thành công!");
                    using (var db = new Manage_evsEntities(clConnection.connectString2))
                    {
                        var product = db.NewInventory_EVS
                            .FirstOrDefault(p => p.Itemcode == _item.ItemCode && p.LotNo == _item.LotNo && p.Qty == _item.R_float1 && p.Qty_Allocate == _item.R_float2);

                        if (product != null)
                        {
                            product.connect_status = "No_connect";
                            db.SaveChanges();
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Hủy kết nối thất bại!");
                }
            }
            else
            {
                return;
            }
        }
    }
}
