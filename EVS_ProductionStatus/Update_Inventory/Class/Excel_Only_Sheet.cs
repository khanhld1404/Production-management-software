
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Update_Inventory.Class
{
    internal class Excel_Only_Sheet
    {
        public static void ExportToExcel(DataGridView datagrid, string fileName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("Thông tin");

                int colCount = datagrid.ColumnCount;
                int rowCount = datagrid.Rows.Cast<DataGridViewRow>()
                                            .Count(r => !r.IsNewRow);

                // 1) Header
                for (int i = 0; i < colCount; i++)
                {
                    ws.Cells[1, i + 1].Value = datagrid.Columns[i].HeaderText;
                }

                // 2) Data
                int excelRow = 2;
                foreach (DataGridViewRow dgvr in datagrid.Rows)
                {
                    if (dgvr.IsNewRow) continue;

                    for (int j = 0; j < colCount; j++)
                    {
                        ws.Cells[excelRow, j + 1].Value = dgvr.Cells[j].Value;
                    }
                    excelRow++;
                }

                if (rowCount > 0)
                {
                    // 3) Xác định vùng dữ liệu (bao gồm header & data)
                    var range = ws.Cells[1, 1, rowCount + 1, colCount];

                    // 4) Tạo Table & áp style 
                    var table = ws.Tables.Add(range, "tblThongTin");
                    table.TableStyle = TableStyles.Medium2;  // màu xanh + bộ lọc

                    // 5) Định dạng
                    ws.Cells[ws.Dimension.Address].AutoFitColumns();
                    ws.View.FreezePanes(2, 1);
                }
                else
                {
                    ws.Cells["A1"].Value = "Không có dữ liệu";
                }

                package.SaveAs(new FileInfo(fileName));
            }
        }
    }
}
