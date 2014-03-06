namespace BGGAPI.Thing
{
    using System;
    using System.Collections.Generic;

    using BGGAPI.Shared;

    /// <summary>
    /// The videos list.
    /// </summary>
    public class VideosList
    {
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets the videos.
        /// </summary>
        public List<Video> Videos { get; set; }
    }

    /// <summary>
    /// The video.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the post date.
        /// </summary>
        public DateTime PostDate { get; set; }
    }

    /// <summary>
    /// The statistics.
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        public List<Ratings> Ratings { get; set; }
    }


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