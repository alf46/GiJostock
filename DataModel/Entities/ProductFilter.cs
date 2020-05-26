using System;

namespace DataModel
{
    public class ProductFilter
    {
        public int? ID { get; set; }

        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public int? WarehouseID { get; set; }
    }
}