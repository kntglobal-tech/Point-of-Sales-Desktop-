//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Inventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.PurchaseChallanDetails = new HashSet<PurchaseChallanDetail>();
        }
    
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long ProductCategoryId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<PurchaseChallanDetail> PurchaseChallanDetails { get; set; }
    }
}