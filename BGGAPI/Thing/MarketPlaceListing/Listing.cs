namespace BGGAPI.Thing.MarketPlaceListing
{
    using BGGAPI.Shared;

    public class Listing
    {
        /// <summary>
        /// Gets or sets the list date.
        /// </summary>
        public DateTimeValue ListDate { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public MoneyValue Price { get; set; }

        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        public StringValue Condition { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public StringValue Notes { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        public LinkValue Link { get; set; }
    }
}
