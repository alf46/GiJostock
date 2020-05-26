using GiJoStock.Properties;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;

namespace GiJoStock
{
    public class Category : BaseEntity, IDisable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image64 { get; set; }

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

        public string GetController()
        {
            return "category";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}