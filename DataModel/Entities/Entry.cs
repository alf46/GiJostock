using DataModel.Repositories;
using System;
using System.Collections.Generic;

namespace DataModel
{
    public class Entry : IDisable
    {
        public int ID { get; set; }

        public int WarehouseID { get; set; }
        public int UserID { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }
        public string Reference { get; set; }

        public Warehouse Warehouse { get; set; }
        public User User { get; set; }

        public bool Enable { get; set; } = true;

        public List<EntryItem> EntryItems { get; set; }
    }
}