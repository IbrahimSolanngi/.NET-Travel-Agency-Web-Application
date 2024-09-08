//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.PurchaseReturns = new HashSet<PurchaseReturn>();
            this.PurchaseReturns1 = new HashSet<PurchaseReturn>();
            this.RequestforQoutations = new HashSet<RequestforQoutation>();
            this.SalesReturns = new HashSet<SalesReturn>();
            this.RecentlyViews = new HashSet<RecentlyView>();
            this.Reviews = new HashSet<Review>();
            this.Wishlists = new HashSet<Wishlist>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> SubCategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public string UnitWeight { get; set; }
        public string Size { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> UnitInStock { get; set; }
        public Nullable<int> UnitOnOrder { get; set; }
        public Nullable<bool> ProductAvailable { get; set; }
        public string ImageURL { get; set; }
        public string AltText { get; set; }
        public Nullable<bool> AddBadge { get; set; }
        public string OfferTitle { get; set; }
        public string OfferBadgeClass { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Note { get; set; }
        public Nullable<int> UnitMeasureID { get; set; }
        public Nullable<bool> InActive { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturns1 { get; set; }
        public virtual ICollection<RequestforQoutation> RequestforQoutations { get; set; }
        public virtual ICollection<SalesReturn> SalesReturns { get; set; }
        public virtual Product Products1 { get; set; }
        public virtual Product Product1 { get; set; }
        public virtual Product Products11 { get; set; }
        public virtual Product Product2 { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
