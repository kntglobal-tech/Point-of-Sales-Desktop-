//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Security
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdditionalScreenPermission
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ScreenId { get; set; }
        public string AccessRight { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual Screen Screen { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
