
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.EVS_Inventories.Class;
using EVS_ProductionStatus.Data_EVS;
namespace EVS_ProductionStatus
{
    class clMethod
    {
        public void DongBoDL()
        {
            try
            {
                string file_url = "";

                // 1) Lấy đường dẫn file excel từ bảng URL (DB EVS_ProductionStatus)
                using (DB_Entities dbUrl = new DB_Entities(clConnection.connectEntity))
                {
                    var qr = dbUrl.tblURLs.FirstOrDefault(x => x.Code == "FILE_URL");
                    if (qr == null || string.IsNullOrWhiteSpace(qr.URL))
                    {
                        MessageBox.Show("Không tìm thấy cấu hình FILE_URL", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    file_url = qr.URL.Trim();

                    if (!File.Exists(file_url))
                    {
                        MessageBox.Show($"Không tìm thấy file \n{file_url}", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // EPPlus license (nếu bạn dùng EPPlus 5+)
                // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                FileInfo inf = new FileInfo(file_url);
                using (ExcelPackage p = new ExcelPackage(inf))
                {
                    var ws = p.Workbook.Worksheets["Data"];
                    if (ws == null)
                    {
                        MessageBox.Show("Không tìm thấy sheet 'Data'", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int colCount = ws.Dimension.End.Column;
                    int rowCount = ws.Dimension.End.Row;

                    // 2) Tạo map: HEADER -> INDEX
                    var col = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                    for (int i = 1; i <= colCount; i++)
                    {
                        var header = ws.Cells[1, i].Text?.Trim();
                        if (!string.IsNullOrEmpty(header) && !col.ContainsKey(header))
                            col.Add(header, i);
                    }

                    // 3) Danh sách cột bắt buộc (bạn có thể thêm/bớt tuỳ yêu cầu)
                    // ID thường identity => không bắt buộc
                    string[] requiredHeaders = new[]
                    {
                        "WORK_ORDER_ID",
                        "WORK_ORDER",
                        "STATUS",
                        "LOT_SERIAL",
                        "WO_PART",
                        "ORDER_QTY"
                        // nếu cần bắt buộc thêm cột nào thì thêm vào đây
                    };

                    var missing = requiredHeaders.Where(h => !col.ContainsKey(h)).ToList();
                    if (missing.Count > 0)
                    {
                        MessageBox.Show("File Excel thiếu các cột: " + string.Join(", ", missing),
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Helper đọc text
                    string GetText(int r, string header)
                    {
                        if (!col.TryGetValue(header, out int c)) return null;
                        var t = ws.Cells[r, c].Text;
                        return string.IsNullOrWhiteSpace(t) ? null : t.Trim();
                    }

                    // Helper parse datetime an toàn (Excel có thể là DateTime, string, hoặc số)
                    DateTime? GetDateTime(int r, string header)
                    {
                        if (!col.TryGetValue(header, out int c)) return null;

                        object v = ws.Cells[r, c].Value;
                        if (v == null) return null;

                        if (v is DateTime dt) return dt;

                        // Excel đôi khi lưu ngày dạng số OADate
                        if (v is double d)
                        {
                            try { return DateTime.FromOADate(d); } catch { return null; }
                        }

                        // string
                        if (DateTime.TryParse(v.ToString(), out DateTime parsed))
                            return parsed;

                        return null;
                    }

                    // 4) Ghi vào DB mới: Manage_evs.dbo.tblWO
                    using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectEntity2))
                    {
                        // Truncate dữ liệu cũ (proc của DB Manage_evs)
                        Other_function.Call_Procedure(clConnection.connectString3, "truncate_tblWO");

                        // Tối ưu insert nhiều dòng
                        wodb.Configuration.AutoDetectChangesEnabled = false;
                        wodb.Configuration.ValidateOnSaveEnabled = false;

                        var buffer = new List<tblWO>(capacity: 1000);

                        for (int r = 2; r <= rowCount; r++)
                        {
                            // Nếu WORK_ORDER rỗng coi như dòng trống
                            if (string.IsNullOrWhiteSpace(GetText(r, "WORK_ORDER")))
                                continue;

                            var tb = new tblWO();

                            // --- VARCHAR(150) ---
                            // tb.ID: thường identity -> không set
                            tb.WORK_ORDER_ID = GetText(r, "WORK_ORDER_ID");
                            tb.WORK_ORDER = GetText(r, "WORK_ORDER");
                            tb.STATUS = GetText(r, "STATUS");

                            tb.ORDER_DATE = GetText(r, "ORDER_DATE");
                            tb.RELEASE_DATE = GetText(r, "RELEASE_DATE");
                            tb.DUE_DATE = GetText(r, "DUE_DATE");

                            tb.LOCATION_ID = GetText(r, "LOCATION_ID");
                            tb.LOT_SERIAL = GetText(r, "LOT_SERIAL");

                            tb.WO_PART = GetText(r, "WO_PART");
                            tb.MES_PART = GetText(r, "MES_PART");

                            tb.DESCRIPTION_FOR_WO_PART_EN = GetText(r, "DESCRIPTION_FOR_WO_PART_EN");
                            tb.DESCRIPTION_FOR_WO_PART_VN = GetText(r, "DESCRIPTION_FOR_WO_PART_VN");

                            tb.DRAWING_REV = GetText(r, "DRAWING_REV");
                            tb.REV = GetText(r, "REV");

                            tb.PROD_LINE = GetText(r, "PROD_LINE");

                            tb.ORDER_QTY = GetText(r, "ORDER_QTY");
                            tb.COMPLETE_QTY = GetText(r, "COMPLETE_QTY");
                            tb.REJECT_QTY = GetText(r, "REJECT_QTY");
                            tb.OPEN_QTY = GetText(r, "OPEN_QTY");

                            tb.WO_COMPONENT = GetText(r, "WO_COMPONENT");
                            tb.MES_COMPONENT = GetText(r, "MES_COMPONENT");

                            tb.DESCRIPTION_FOR_WO_COMPONENT_EN = GetText(r, "DESCRIPTION_FOR_WO_COMPONENT_EN");
                            tb.DESCRIPTION_FOR_WO_COMPONENT_VN = GetText(r, "DESCRIPTION_FOR_WO_COMPONENT_VN");

                            tb.ITEM_TYPE = GetText(r, "ITEM_TYPE");
                            tb.LOT_SERIAL_ALLOCATE = GetText(r, "LOT_SERIAL_ALLOCATE");
                            tb.REQUIRE_QTY = GetText(r, "REQUIRE_QTY");

                            tb.STORAGE_LOCATION = GetText(r, "STORAGE_LOCATION");
                            tb.QTY_ISSUED = GetText(r, "QTY_ISSUED");

                            tb.CREATED_BY = GetText(r, "CREATED_BY");
                            tb.LAST_UPDATED_BY = GetText(r, "LAST_UPDATED_BY");

                            // --- DATETIME ---
                            tb.CREATION_DATE = GetDateTime(r, "CREATION_DATE");
                            tb.LAST_UPDATE_DATE = GetDateTime(r, "LAST_UPDATE_DATE");

                            buffer.Add(tb);

                            // Batch insert
                            if (buffer.Count >= 1000)
                            {
                                wodb.tblWOes.AddRange(buffer);
                                wodb.SaveChanges();
                                buffer.Clear();
                            }
                        }

                        // flush batch cuối
                        if (buffer.Count > 0)
                        {
                            wodb.tblWOes.AddRange(buffer);
                            wodb.SaveChanges();
                            buffer.Clear();
                        }

                        MessageBox.Show("Đồng bộ WO thành công", "OK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}