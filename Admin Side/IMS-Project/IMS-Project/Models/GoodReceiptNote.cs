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
    
    public partial class GoodReceiptNote
    {
        public int GoodRecieptNote { get; set; }
        public Nullable<int> SupplierQoutationID { get; set; }
        public Nullable<int> ReqQoutationID { get; set; }
        public string Product { get; set; }
        public string Supplier { get; set; }
        public Nullable<int> QuantityNeeded { get; set; }
        public Nullable<int> SupplierQuantity { get; set; }
        public Nullable<int> UnitPrice { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public string SupQuantity { get; set; }
        public string ConUnit { get; set; }
        public string Tax { get; set; }
        public Nullable<int> PaymentTerm { get; set; }
    
        public virtual RequestforQoutation RequestforQoutation { get; set; }
    }
}
