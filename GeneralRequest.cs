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
    
    public partial class GeneralRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GeneralRequest()
        {
            this.ActionHistories = new HashSet<ActionHistory>();
            this.Emnployees = new HashSet<Emnployee>();
        }
    
        public int RequestId { get; set; }
        public Nullable<int> RequestNo { get; set; }
        public string EmpNumber { get; set; }
        public string EmpFullNameAr { get; set; }
        public string EmpFullNameEn { get; set; }
        public string EmpUserName { get; set; }
        public Nullable<int> ServiceTypeId { get; set; }
        public Nullable<int> StepId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> ProcessId { get; set; }
        public Nullable<System.DateTime> ActionLastDateTime { get; set; }
        public Nullable<bool> OnBehalf { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionHistory> ActionHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emnployee> Emnployees { get; set; }
    }
}