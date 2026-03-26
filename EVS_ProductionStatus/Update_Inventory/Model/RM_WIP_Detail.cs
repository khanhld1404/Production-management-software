using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.Update_Inventory.Model
{
    internal class RM_WIP_Detail
    {
        public string ItemCode { get; set; }
        public string Lotno { get; set; }
        public string Status { get; set; }
        public double Tồn { get; set; }
        public double Allocate { get; set; }
        public double Khả_dụng { get; set; }
    }
}
