using EVS_Management.EVS_Inventories.Class;
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

namespace EVS_Management.Class
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
                    Other_function.Call_Procedure(clConnection.connectString,"Update_Inventory");
                    return true;
                }
            }
        }
    }
}
