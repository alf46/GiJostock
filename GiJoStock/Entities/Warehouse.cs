namespace GiJoStock
{
    public class Warehouse : BaseEntity, IDisable
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public bool Default { get; set; } = true;

        public override string ToString()
        {
            return this.Name;
        }
    }
}