namespace GiJoStock
{
    public class ProductUp : IDisable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuantityPerUnit { get; set; }
        public string Barcode { get; set; }
        public double PriceIN { get; set; }
        public double PriceOUT { get; set; }
        public string Image64 { get; set; }

        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int UserID { get; set; }
    }
}