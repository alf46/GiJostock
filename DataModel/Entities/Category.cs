using DataModel.Repositories;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DataModel
{
    public class Category : IDisable
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Image64 { get; set; }

        public bool Enable { get; set; } = true;

        [IgnoreDataMember]
        public virtual List<Product> Products { get; set; }
    }
}