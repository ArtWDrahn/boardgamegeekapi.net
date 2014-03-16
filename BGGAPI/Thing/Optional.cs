namespace BGGAPI.Thing
{
    using System;
    using System.Collections.Generic;

    using BGGAPI.Shared;

    /// <summary>
    /// The marketplace listings.
    /// </summary>
    public class MarketplaceListings
    {
        /// <summary>
        /// Gets or sets the listings.
        /// </summary>
        public List<Listing> Listings { get; set; }
    }

    /// <summary>
    /// The listing.
    /// </summary>
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