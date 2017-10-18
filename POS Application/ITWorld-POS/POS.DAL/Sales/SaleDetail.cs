//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Sales
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleDetail
    {
        public long Id { get; set; }
        public long SaleId { get; set; }
        public long ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal ProductDiscountInPercentage { get; set; }
        public decimal ProductDiscountAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual Sale Sale { get; set; }
    }
}
