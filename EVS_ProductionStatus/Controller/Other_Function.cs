using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.Controller
{
    internal class Other_Function
    {
        //Hàm để gọi một procedure dưới  cơ sở dữ liệu giúp truyền dữ liệu từ cơ sở dữ liệu được bên mes đẩy lên sang bên cơ sở dữ liệu xử lý
        public static void UpdateInventory()
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
