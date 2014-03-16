namespace BGGAPI.Thing
{
    using System.Collections.Generic;

    /// <summary>
    /// The object that is returned when a request is made for a thing.
    /// </summary>
    public class Return : Shared.Return
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }
    }

    /// <summary>
    /// The links for the thing.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string value { get; set; }
    }
}
