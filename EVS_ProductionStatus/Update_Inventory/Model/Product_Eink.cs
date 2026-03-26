using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.Update_Inventory.Model
{
    public class Product_Eink
    {

        public string ItemCode { get; set; }
        public string LotNo { get; set; }
        public double? R_float1 { get; set; }      
        public double? R_float2 { get; set; }

    }
}
