using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Class
{
    public class Reload_Inventory_Infor
    {
        //Hàm để thực hiện việc load lại dữ liệu
        public async Task<bool> CallInventoryApiAsync(string url)
        {
            using (var client = new HttpClient())
            {
                // Nếu API không cần body -> gửi object rỗng {}
                var content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);

                // Lấy chuỗi JSON trả về
                string result = await response.Content.ReadAsStringAsync();

                if ((int)response.StatusCode == 429)
                {
                    // Parse JSON
                    var json = JsonDocument.Parse(result).RootElement;
                    string error = json.GetProperty("error").GetString();
                    int retryAfter = json.GetProperty("retry_after_seconds").GetInt32();

                    if (error != "Too many requests")
                    {
                        MessageBox.Show("Cập nhật dữ liệu không thành công!");
                        return false;
                    }
                    else
                    {

                        MessageBox.Show($"Cập nhật lại sau: {retryAfter} giây ", "Chưa thể cập nhật hiện tại!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                        );
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show($"Cập nhật dữ liệu thành công !");
                    UpdateInventory();
                    return true;
                }
            }
        }
        //Hàm để gọi một procedure dưới  cơ sở dữ liệu giúp truyền dữ liệu từ cơ sở dữ liệu được bên mes đẩy lên sang bên cơ sở dữ liệu xử lý
        public void UpdateInventory()
        {
            using (SqlConnection conn = new SqlConnection(clConnection.connectString))
            {
                using (SqlCommand cmd = new SqlCommand("Update_Inventory", conn))
                {
                    //Xác định đóng gói logic phía  sql, giống với câu lệnh gọi rpocedure excec
                    cmd.CommandType = CommandType.StoredProcedure; // Quan trọng
                    cmd.CommandTimeout = 150;                      // 150 giây

                    try
                    {
                        conn.Open();  
                        //Dùng excute non query để không lấy kết quả trả về như select, insert các thứ// Quan trọng
                        cmd.ExecuteNonQuery();     // Gọi thủ tục
                    }
                    catch (SqlException ex)
                    {
                        // TODO: log ex (ex.Message, ex.Number, ex.Procedure, ex.LineNumber,...)
                        throw; // hoặc wrap thành exception của domain tuỳ nhu cầu
                    }

                }
            }
        }
    }
}
