﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EsemkaCorporationEntities : DbContext
    {
        public EsemkaCorporationEntities()
            : base("name=EsemkaCorporationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<job_level> job_level { get; set; }
        public virtual DbSet<mutation> mutations { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<promotion> promotions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}