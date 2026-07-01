using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    public class InventoryResult
    {
        public string GridName { get; set; }

        public double Blocked_HFG { get; set; }
        public double UU_HFG { get; set; }
        public double QI_HFG { get; set; }
        public double Res_HFG { get; set; }
        public double Total_HFG { get; set; }

        public double Blocked_RM { get; set; }
        public double UU_RM { get; set; }
        public double QI_RM { get; set; }
        public double Res_RM { get; set; }
        public double Total_RM { get; set; }

        public double Blocked_WIP { get; set; }
        public double UU_WIP { get; set; }
        public double QI_WIP { get; set; }
        public double Res_WIP { get; set; }
        public double Total_WIP { get; set; }
    }
}
