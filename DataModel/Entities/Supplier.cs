using DataModel.Repositories;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DataModel
{
    public class Supplier : IDisable
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public bool Enable { get; set; } = true;

        [IgnoreDataMember]
        public List<Product> Products { get; set; }

        [IgnoreDataMember]
        public List<Invoice> Invoices { get; set; }
    }
}