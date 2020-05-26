using DataModel.Repositories;
using System;
using System.Collections.Generic;

namespace DataModel
{
    public class Invoice : IDisable
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public string Reference { get; set; }
        public string Observations { get; set; }
        public string PaymentMethod { get; set; }

        public int WarehouseID { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }

        public decimal Amount { get; set; }

        public bool Enable { get; set; } = true;

        public Warehouse Warehouse { get; set; }
        public Supplier Supplier { get; set; }
        public User User { get; set; }

        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}