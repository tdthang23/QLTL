using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataLayer;

namespace businessLayer.DTO
{
    public class NHANVIEN_DTO
    {
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string GT { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> NGAYVAOLAM { get; set; }
        public string MAPB { get; set; }
        public string TENPB { get; set; }
        public string MACV { get; set; }
        public string TENCV { get; set; }
        public Nullable<decimal> LUONGCB { get; set; }
    }
}
