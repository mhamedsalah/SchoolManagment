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
    
    public partial class tUserAccessRole
    {
        public int UserAccessRolID { get; set; }
        public int UserID { get; set; }
        public int AccessRoleID { get; set; }
    
        public virtual tAccessRole tAccessRole { get; set; }
        public virtual tUser tUser { get; set; }
    }
}