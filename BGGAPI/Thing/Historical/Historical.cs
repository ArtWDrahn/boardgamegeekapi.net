using System.Collections.Generic;

namespace BGGAPI.Thing.Historical
{
    using BGGAPI.Shared;


    /// <summary>
    /// The Comments object returned.
    /// </summary>
    public class Item : Thing.Item
    {
        // TODO: Historical: this is really statistics with more data unclear how to get this implimented.
        /// <summary>
        /// Gets or sets the statistics.
        /// </summary>
        // public Statistcs Statistics { get; set; }
    }

    /// <summary>
    /// The statistics.
    /// </summary>
    public class Statistcs
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        public List<Ratings> Ratings { get; set; }

        public string Date { get; set; }
    }
}
