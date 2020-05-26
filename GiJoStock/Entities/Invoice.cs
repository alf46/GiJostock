using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GiJoStock
{
    public class Invoice : BaseEntity, IDisable
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public string Reference { get; set; }
        public string Observations { get; set; }
        public string PaymentMethod { get; set; }

        public int WarehouseID { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }

        public Warehouse Warehouse { get; set; }
        public Supplier Supplier { get; set; }
        public User User { get; set; }

        [JsonIgnore]
        public int Items
        {
            get
            {
                return this.InvoiceItems == null ? 0 : this.InvoiceItems.Count;
            }
        }

        public decimal Amount { get; set; }

        [JsonIgnore]
        public string AmountStr => "RD$ " + string.Format("{0:#,0.00}", this.Amount);

        public List<InvoiceItem> InvoiceItems { get; set; }

        public void SetProductProperties()
        {
            if (this.InvoiceItems != null)
            {
                foreach (var item in this.InvoiceItems)
                {
                    item.PriceOUT = item.Product.PriceOUT;
                    item.Name = item.Product.Name;
                }
            }
        }

        public override string ToString()
        {
            var year = "I" + this.Date.ToString("mm{0}dd");
            return string.Format(year, this.ID);
        }
    }
}