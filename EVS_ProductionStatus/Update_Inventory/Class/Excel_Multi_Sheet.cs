using EVS_ProductionStatus;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Update_Inventory.Class
{
    internal class Excel_Multi_Sheet
    {
        public static void ExportToExcel<T1,T2>(List<T1> a1, List<T2> a2, string fileName)
        {
            try
            {
                // Khai báo license (bắt buộc từ EPPlus 5+)
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Tạo file .xlsx
                using (var package = new ExcelPackage())
                {
                    // --- Sheet 1: Summary by Item (summary3) ---
                    var ws1 = package.Workbook.Worksheets.Add("Tổng quan");

                    if (a1 != null && a1.Count > 0)
                    {
                        // Nạp danh sách -> tự tạo header từ tên property
                        ws1.Cells["A1"].LoadFromCollection(a1, PrintHeaders: true, TableStyle: TableStyles.Medium2);

                        // Định dạng
                        ws1.Cells[ws1.Dimension.Address].AutoFitColumns();
                        ws1.View.FreezePanes(2, 1); // cố định hàng header
                                                    // AutoFilter có sẵn khi dùng TableStyles; nếu không dùng table:
                                                    // ws1.Cells[ws1.Dimension.Address].AutoFilter = true;
                    }
                    else
                    {
                        ws1.Cells["A1"].Value = "Không có dữ liệu ";
                    }

                    // --- Sheet 2: Summary by Lot (summary4) ---
                    var ws2 = package.Workbook.Worksheets.Add("Chi tiết");

                    if (a2 != null && a2.Count > 0)
                    {
                        ws2.Cells["A1"].LoadFromCollection(a2, PrintHeaders: true, TableStyle: TableStyles.Medium9);
                        ws2.Cells[ws2.Dimension.Address].AutoFitColumns();
                        ws2.View.FreezePanes(2, 1);
                    }
                    else
                    {
                        ws2.Cells["A1"].Value = "Không có dữ liệu ";
                    }

                    // Lưu ra đĩa
                    var fi = new FileInfo(fileName);
                    package.SaveAs(fi);
                }

                MessageBox.Show("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi EPPlus: " + ex.Message);
            }
        }
    }
}
