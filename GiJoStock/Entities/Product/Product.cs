using GiJoStock.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace GiJoStock
{
    public class Product : BaseEntity, IDisable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QuantityPerUnit { get; set; }
        public string Barcode { get; set; }

        public double PriceIN { get; set; }
        public double PriceOUT { get; set; }

        public string Image64 { get; set; }

        [JsonIgnore]
        public string PriceINStr => "RD$ " + string.Format("{0:#,0.00}", this.PriceIN);

        [JsonIgnore]
        public string PriceOUTStr => "RD$ " + string.Format("{0:#,0.00}", this.PriceOUT);

        public DateTime CreateDate { get; set; }

        public string DateStr => this.CreateDate.ToString("dd-MM-yyyy");

        public double AvailableQuantity
        {
            get
            {
                return this.Warehouses != null ? this.Warehouses.Where(x => x.Warehouse.Enable).Sum(x => x.Stock) : 0;
            }
        }

        [JsonIgnore]
        public Image Image
        {
            get
            {
                if (this.Image64 == null)
                {
                    return Resources._default;
                }

                byte[] bytes = Convert.FromBase64String(this.Image64);

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            set
            {
                if (value == null)
                {
                    this.Image64 = null;
                    return;
                }

                // Asignar la imagen del producto.
                using (var stream = new MemoryStream())
                {
                    value.Save(stream, value.RawFormat);

                    // Convert byte[] to Base64 String
                    this.Image64 = Convert.ToBase64String(stream.ToArray());
                }
            }
        }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        public List<ProductWarehouse> Warehouses { get; set; }
    }
}