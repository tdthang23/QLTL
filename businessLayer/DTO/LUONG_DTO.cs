using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.DTO
{
    public class LUONG_DTO
    {
        public int MABL { get; set; }
        public string MABCC { get; set; }
        public Nullable<int> SONC { get; set; }
        public Nullable<int> TANGCA { get; set; }
        public Nullable<int> MUON { get; set; }
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<decimal> BHXH { get; set; }
        public Nullable<decimal> BHYT { get; set; }
        public Nullable<decimal> THUETNCN { get; set; }
        public Nullable<decimal> THUCLANH { get; set; }
    }
}
