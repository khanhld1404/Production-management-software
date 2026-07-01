using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    public class EVS_Inventory_Total
    {
        public string Storage_Location {  get; set; }
        public string Stock_Type { get; set; }
        public string MRP_Controller { get; set; }
        public double SL {  get; set; }

    }
}
