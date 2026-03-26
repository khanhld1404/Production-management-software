using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.Update_Inventory.Model
{
    internal class RM_WIP_Overview
    {
        public string ItemCode { get; set; }
        public double Total { get; set; }
        public double Total_Allocate { get; set; }
        public double Total_khả_dụng { get; set; }
    }
}
