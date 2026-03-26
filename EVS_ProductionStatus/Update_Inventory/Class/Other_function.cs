using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    }
}