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
    
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
    
        public long Id { get; set; }
        public string ProductCategoryName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
