using System;

namespace DataModel
{
    public class PhysicalInventory
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double PriceIN { get; set; }
        public double PriceOUT { get; set; }
        public double AvailableQuantity { get; set; }

        public DateTime Date { get; set; }
    }
}