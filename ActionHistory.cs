//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ActionHistory
    {
        public int Id { get; set; }
        public Nullable<int> RequestId { get; set; }
        public string Remark { get; set; }
        public Nullable<int> StepId { get; set; }
        public Nullable<int> ActionId { get; set; }
        public string ActionName { get; set; }
        public string ActionByUserName { get; set; }
        public string ActionByDisplayName { get; set; }
        public Nullable<System.DateTime> ActionDateTime { get; set; }
        public string UserActionGroup { get; set; }
    
        public virtual GeneralRequest GeneralRequest { get; set; }
        public virtual Action Action { get; set; }
    }
}