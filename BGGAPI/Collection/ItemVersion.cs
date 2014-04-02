using System.Collections.Generic;
using BGGAPI.Shared;

namespace BGGAPI.Collection
{
    public class ItemVersion
    {
        public string Thumbnail { get; set; }

        public string Image { get; set; }

        public List<LinkValue> Links { get; set; }

        public Name Name { get; set; }

        public string YearPublished { get; set; }

        public string ProductCode { get; set; }

        public DoubleValue Width { get; set; }

        public DoubleValue Length { get; set; }

        public DoubleValue Depth { get; set; }

        public DoubleValue Weight { get; set; }
    }
}