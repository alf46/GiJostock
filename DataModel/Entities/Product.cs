using DataModel.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DataModel
{
    public class Product : IDisable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuantityPerUnit { get; set; }
        public string Barcode { get; set; }

        public decimal PriceIN { get; set; }
        public decimal PriceOUT { get; set; }

        public string Image64 { get; set; }

        public decimal? Stock => this.ProductWarehouses?.Where(x => x.Warehouse.Enable).Sum(x => x.Stock);

        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }

        public bool Enable { get; set; } = true;

        public DateTime CreateDate { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public User User { get; set; }

        [JsonProperty("warehouses")]
        public List<ProductWarehouse> ProductWarehouses { get; set; }

        [IgnoreDataMember]
        public List<EntryItem> EntryItems { get; set; }
    }
}