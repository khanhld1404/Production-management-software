using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    public class Inventories_Total
    {
        public string Item {  get; set; }
        public string Lot { get; set; }
        public string Location { get; set; }
        public double UU {  get; set; }
        public double Restricted {  get; set; }
        public double Blocked {  get; set; }
        public double QI {  get; set; }
        public double Total { get; set; }
    }
}
