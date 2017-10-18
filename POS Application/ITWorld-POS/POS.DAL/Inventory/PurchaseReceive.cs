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
    
    public partial class PurchaseReceive
    {
        public PurchaseReceive()
        {
            this.PurchaseReceiveDetails = new HashSet<PurchaseReceiveDetail>();
            this.PurchaseReturns = new HashSet<PurchaseReturn>();
        }
    
        public long Id { get; set; }
        public string ReceiveNumber { get; set; }
        public System.DateTime ReceiveDate { get; set; }
        public string ReceivedBy { get; set; }
        public string ReceivedFrom { get; set; }
        public long ChallanId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual PurchaseChallan PurchaseChallan { get; set; }
        public virtual ICollection<PurchaseReceiveDetail> PurchaseReceiveDetails { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; }
    }
}
