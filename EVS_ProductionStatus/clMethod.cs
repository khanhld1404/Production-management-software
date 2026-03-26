using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    class clMethod
    {

        public void DongBoDL()
        {
            try
            {
                string file_url = "";
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblURLs
                              where s.Code == "FILE_URL"
                              select s).FirstOrDefault();
                    if (qr != null)
                    {
                        file_url = qr.URL;
                        if (!File.Exists(file_url))
                        {
                            MessageBox.Show(String.Format("Không tìm thấy file \n {0}", file_url), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        FileInfo inf = new FileInfo(qr.URL);
                        using (ExcelPackage p = new ExcelPackage(inf))
                        {
                            var ws = p.Workbook.Worksheets["Data"];
                            int colCount = ws.Dimension.End.Column;
                            int rowCount = ws.Dimension.End.Row;

                            int wo_index = 0, status_index = 0, id_index = 0,
                                lot_index = 0, item_index = 0, desc1_index = 0, desc2_index = 0, qty_index = 0;
                            //Lay chi so cot cua cac truong can lay gia tri
                            for (int i = 1; i <= colCount; i++)
                            {
                                switch (ws.Cells[1, i].Value.ToString())
                                {
                                    case "ID":
                                        id_index = i;
                                        break;
                                    case "Work Order":
                                        wo_index = i;
                                        break;
                                    case "Work Order Status":
                                        status_index = i;
                                        break;
                                    //case "Order Date":
                                    //    orderdate_index = i;
                                    //    break;
                                    case "Lot/Serial":
                                        lot_index = i;
                                        break;
                                    case "Item Number":
                                        item_index = i;
                                        break;
                                    case "Description 1":
                                        desc1_index = i;
                                        break;
                                    case "Description 2":
                                        desc2_index = i;
                                        break;
                                    case "Order Qty":
                                        qty_index = i;
                                        break;
                                }
                            }

                            if (wo_index == 0 || status_index == 0 || id_index == 0 ||
                                lot_index == 0 || item_index == 0 || desc1_index == 0 || desc2_index == 0 || qty_index == 0)
                            {
                                MessageBox.Show("Định dạng file không phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            //Truncate bang chua du lieu cu
                            db.pro_01_truncateWO();

                            //Lay gia tri vao bang luu WO
                            for (int i = 2; i <= rowCount; i++)
                            {
                                if (ws.Cells[i, wo_index].Value != null)
                                {
                                    tblWO tb = new tblWO();
                                    tb.WOID = ws.Cells[i, id_index].Value.ToString();
                                    tb.workorder = ws.Cells[i, wo_index].Value.ToString();
                                    tb.wostatus = ws.Cells[i, status_index].Value.ToString();
                                    //tb.orderdate = Convert.ToDateTime(ws.Cells[i, orderdate_index].Value);
                                    tb.lot = ws.Cells[i, lot_index].Value.ToString();
                                    tb.itemnumber = ws.Cells[i, item_index].Value.ToString();
                                    tb.desc1 = ws.Cells[i, desc1_index].Value.ToString();
                                    tb.desc2 = ws.Cells[i, desc2_index].Value.ToString();
                                    tb.qty = Convert.ToInt32(ws.Cells[i, qty_index].Value);
                                    db.tblWOes.Add(tb);
                                }
                            }
                            db.SaveChanges();
                            MessageBox.Show("Đồng bộ thành công");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
