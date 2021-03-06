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
    
    public partial class PurchaseChallanDetail
    {
        public PurchaseChallanDetail()
        {
            this.PurchaseReceiveDetails = new HashSet<PurchaseReceiveDetail>();
        }
    
        public long Id { get; set; }
        public long PurchaseChallanId { get; set; }
        public long ProductId { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual PurchaseChallan PurchaseChallan { get; set; }
        public virtual ICollection<PurchaseReceiveDetail> PurchaseReceiveDetails { get; set; }
    }
}
