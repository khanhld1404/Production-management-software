using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS_Management.EVS_Inventories.Model
{
    public class Kitting_Data
    {
        public long Nhóm_Kitting {  get; set; }
        public string Item_Wo {  get; set; }
        public string ID_Wo { get; set; }
        public int Số_Lượng {  get; set; }
    }
}
