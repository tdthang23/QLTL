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
    
    public partial class tb_LUONG
    {
        public int MABL { get; set; }
        public string MABCC { get; set; }
        public string MANV { get; set; }
        public Nullable<decimal> BHXH { get; set; }
        public Nullable<decimal> BHYT { get; set; }
        public Nullable<decimal> THUETNCN { get; set; }
        public Nullable<decimal> THUCLANH { get; set; }
    
        public virtual tb_CHAMCONG tb_CHAMCONG { get; set; }
    }
}
