//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NHANVIEN()
        {
            this.tb_CHAMCONG = new HashSet<tb_CHAMCONG>();
        }
    
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string GT { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> NGAYVAOLAM { get; set; }
        public string MAPB { get; set; }
        public string MACV { get; set; }
        public Nullable<decimal> LUONGCB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CHAMCONG> tb_CHAMCONG { get; set; }
        public virtual tb_CHUCVU tb_CHUCVU { get; set; }
        public virtual tb_PHONGBAN tb_PHONGBAN { get; set; }
    }
}
