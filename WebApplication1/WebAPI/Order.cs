//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Order_Id { get; set; }
        public Nullable<int> Item_Id { get; set; }
        public Nullable<int> Table_Id { get; set; }
        public Nullable<int> Invoice_Id { get; set; }
        public Nullable<int> Staff_Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Remark { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Item Item { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Table Table { get; set; }
    }
}