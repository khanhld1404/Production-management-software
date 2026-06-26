using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    internal class RM_WIP_Elink
    {
        public string MATERIAL { get; set; }
        public string Batch { get; set; }
        public double Tổng_Tồn { get; set; }
        public double Tồn_Allowcate { get; set; }
        public double Tồn_Khả_Dụng { get; set; }
        public string Connect_Eink { get; set; }
    }
}
