﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Second_Electricity_POC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeaveDemoEntities : DbContext
    {
        public LeaveDemoEntities()
            : base("name=LeaveDemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionHistory> ActionHistories { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Emnployee> Emnployees { get; set; }
        public virtual DbSet<GeneralRequest> GeneralRequests { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<RemarManagement> RemarManagements { get; set; }
    }
}