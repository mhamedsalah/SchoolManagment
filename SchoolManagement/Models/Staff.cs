//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int EmployeeID { get; set; }
        public string FirstName_ar { get; set; }
        public string FirstName_en { get; set; }
        public string LastName_ar { get; set; }
        public string LastName_en { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> GenderID { get; set; }
        public string Telephone { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> HiringDate { get; set; }
        public Nullable<int> YearsOfService { get; set; }
        public int SpecialtyID { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Specialty Specialty { get; set; }
    }
}
