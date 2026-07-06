using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model.EVS
{
    public class EVS_Inventory_Alowcate
    {
        public string Item { get; set; }
        public string Lot {  get; set; }
        public double Ton { get; set; }
        public double Alowcate { get; set; }
        public double KD { get; set; }
        public string Connect {  get; set; }
    }
}
