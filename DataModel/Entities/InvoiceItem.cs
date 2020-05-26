namespace DataModel
{
    public class InvoiceItem
    {
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }

        public double PriceIN { get; set; }
        public double PriceOUT { get; set; }

        public int Stock { get; set; }

        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}