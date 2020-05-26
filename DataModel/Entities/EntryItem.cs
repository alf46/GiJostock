namespace DataModel
{
    public class EntryItem
    {
        public int EntryID { get; set; }
        public int ProductID { get; set; }

        public int Stock { get; set; }

        public Entry Entry { get; set; }
        public Product Product { get; set; }
    }
}