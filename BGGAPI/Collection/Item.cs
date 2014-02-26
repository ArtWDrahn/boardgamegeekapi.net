namespace BGGAPI.Collection
{
    /// <summary>
    /// The returned Collection object.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the object type.
        /// Only have seen "thing" listed in the XML
        /// </summary>
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the object id.
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the sub type.
        /// Only have seen "board game" in the XML.
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// Gets or sets the collection id.
        /// </summary>
        public int CollId { get; set; }

        /// <summary>
        /// Gets or sets the name of the game.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the year the game was published.
        /// </summary>
        public string YearPublished { get; set; }

        /// <summary>
        /// Gets or sets the image url for the game.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        public Stats Stats { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail for the game.
        /// </summary>
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the number of plays for the game.
        /// </summary>
        public int NumPlays { get; set; }
    }
}
