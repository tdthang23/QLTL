﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTLEntities : DbContext
    {
        public QLTLEntities()
            : base("name=QLTLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_CHAMCONG> tb_CHAMCONG { get; set; }
        public virtual DbSet<tb_CHUCVU> tb_CHUCVU { get; set; }
        public virtual DbSet<tb_LUONG> tb_LUONG { get; set; }
        public virtual DbSet<tb_NHANVIEN> tb_NHANVIEN { get; set; }
        public virtual DbSet<tb_PHONGBAN> tb_PHONGBAN { get; set; }
    }
}
