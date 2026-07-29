using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model.EVS
{
    public class EVS_Inventory_Alowcate
    {
        public string Location {  get; set; }
        public string Item { get; set; }
        public string Lot {  get; set; }
        public double UU { get; set; }
        public double Restricted { get; set; }
        public double Blocked { get; set; }
        public double Total { get; set; }
        public double Alowcate { get; set; }
        public double KD { get; set; }
        public string Connect {  get; set; }
    }
}
