
namespace BGGAPI.Search
{
    using System.Collections.Generic;
    using BGGAPI.Shared;

    public class Return
    {
        public int Total { get; set; }

        public List<Item> Items { get; set; } 
    }

    public class Item
    {
        public string Type { get; set; }

        public int ID { get; set; }

        public Name Name { get; set; }

        public StringValue YearPublished { get; set; }
    }
}
