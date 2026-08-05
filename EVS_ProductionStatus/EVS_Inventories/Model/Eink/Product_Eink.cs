using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    public class Product_Eink
    {

        public string ItemCode { get; set; }
        public string LotNo { get; set; }

        public string Location { get; set; }
        public double? R_float1 { get; set; }      
        public double? R_float2 { get; set; }
        public double? R_float3 { get; set; }
    }
}
