using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Update_Inventory.Class
{
    public class Other_function
    {
        // Chuyển dữ liệu list sang dạng bảng datatable
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Lấy tất cả thuộc tính của T
            var props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        // Đưa usercontrol vào một form
        public static void ShowUserControlAsForm(UserControl uc, string title)
        {
            Form frm = new Form();
            frm.Text = title;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = uc.Size; // hoặc frm.AutoSize = true;
            frm.Controls.Add(uc);
            uc.Dock = DockStyle.Fill; // Cho vừa form

            frm.Show(); // hoặc frm.Show();
        }

        //Hàm để gọi một procedure dưới  cơ sở dữ liệu giúp truyền dữ liệu từ cơ sở dữ liệu được bên mes đẩy lên sang bên cơ sở dữ liệu xử lý
        public static void UpdateWOdb()
        {
            using (SqlConnection conn = new SqlConnection(clConnection.connectString3))
            {
                using (SqlCommand cmd = new SqlCommand("update_tblWO", conn))
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