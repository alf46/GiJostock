using System.Runtime.Serialization;

namespace DataModel
{
    public class ProductWarehouse
    {
        [IgnoreDataMember]
        public int ProductID { get; set; }

        [IgnoreDataMember]
        public int WarehouseID { get; set; }

        public int Stock { get; set; }

        public Product Product { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}