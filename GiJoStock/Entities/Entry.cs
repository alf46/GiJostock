using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GiJoStock
{
    public class Entry : BaseEntity, IDisable
    {
        public int ID { get; set; }

        public int WarehouseID { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
        public string Reference { get; set; }

        public Warehouse Warehouse { get; set; }
        public User User { get; set; }

        [JsonIgnore]
        public int Items
        {
            get
            {
                return this.EntryItems == null ? 0 : this.EntryItems.Count;
            }
        }
        public List<EntryItem> EntryItems { get; set; }

        public void SetProductProperties()
        {
            if (this.EntryItems != null)
            {
                foreach (var item in this.EntryItems)
                {
                    item.PriceIN = item.Product.PriceOUT;
                    item.Name = item.Product.Name;
                }
            }
        }

        public override string ToString()
        {
            var year = "E" + this.Date.ToString("mm{0}dd");
            return string.Format(year, this.ID);
        }
    }
}