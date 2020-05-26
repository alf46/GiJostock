using Newtonsoft.Json;

namespace GiJoStock
{
    public class EntryItem
    {
        public int ProductID { get; set; }

        public string Name { get; set; }
        public double PriceIN { get; set; }

        [JsonIgnore]
        public string PriceStr => string.Format("RD$ {0:#,0.00}", this.PriceIN);

        [JsonIgnore]
        public string TotalPrice => string.Format("RD$ {0:#,0.00}", (this.PriceIN * this.Stock));

        [JsonIgnore]
        public double? AvailableQuantity { get; set; }

        public int Stock { get; set; }

        public Product Product { get; set; }

        [JsonIgnore]
        public string Category { get; set; }
    }
}