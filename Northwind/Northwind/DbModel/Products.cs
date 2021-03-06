using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Northwind.DbModel
{
    [Serializable]
    public partial class Products : ISerializable
    {
        public Products()
        {
            InventoryTransactions = new HashSet<InventoryTransactions>();
            OrderDetails = new HashSet<OrderDetails>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetails>();
        }

        public string SupplierIds { get; set; }
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public int? ReorderLevel { get; set; }
        public int? TargetLevel { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
        public int? MinimumReorderQuantity { get; set; }
        public string Category { get; set; }
        
        [XmlIgnore]
        public byte[] Attachments { get; set; }

        [XmlIgnore]
        public virtual ICollection<InventoryTransactions> InventoryTransactions { get; set; }
        [XmlIgnore]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        [XmlIgnore]
        public virtual ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("SupplierIds", SupplierIds);
            info.AddValue("Id", Id);
            info.AddValue("ProductCode", ProductCode);
            info.AddValue("ProductName", ProductName);
            info.AddValue("Description", Description);
            info.AddValue("StandardCost", StandardCost);
            info.AddValue("ListPrice", ListPrice);
            info.AddValue("ReorderLevel", ReorderLevel);
            info.AddValue("TargetLevel", TargetLevel);
            info.AddValue("QuantityPerUnit", QuantityPerUnit);
            info.AddValue("Discontinued", Discontinued);
            info.AddValue("MinimumReorderQuantity", MinimumReorderQuantity);
            info.AddValue("Category", Category);
        }
    }
}
