﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeyawoPortfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBMyPortfolioEntities : DbContext
    {
        public DBMyPortfolioEntities()
            : base("name=DBMyPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLABOUT> TBLABOUT { get; set; }
        public virtual DbSet<TBLCATEGORY> TBLCATEGORY { get; set; }
        public virtual DbSet<TBLCONTACT> TBLCONTACT { get; set; }
        public virtual DbSet<TBLFUTURE> TBLFUTURE { get; set; }
        public virtual DbSet<TBLPROJECT> TBLPROJECT { get; set; }
        public virtual DbSet<TBLSERVİCE> TBLSERVİCE { get; set; }
        public virtual DbSet<TBLSOCIALMEDIA> TBLSOCIALMEDIA { get; set; }
        public virtual DbSet<TBLTESTIMONIAL> TBLTESTIMONIAL { get; set; }
        public virtual DbSet<TBLADMINSIDEBAR> TBLADMINSIDEBAR { get; set; }
        public virtual DbSet<TBLEDUCATION> TBLEDUCATION { get; set; }
    
        public virtual ObjectResult<string> LASTPROJECTNAME()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LASTPROJECTNAME");
        }
    }
}
