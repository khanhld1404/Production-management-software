using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.Update_Inventory.Model
{
    internal class RM_WIP_Overview
    {
        public string MATERIAL_CODE { get; set; }
        public decimal Total { get; set; }
        public decimal Blocked { get; set; }
        public decimal UU { get; set; }

        public decimal QI { get; set; }

        public decimal Restricted {  get; set; }
    }
}
