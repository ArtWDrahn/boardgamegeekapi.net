namespace BGGAPI.Thing
{
    using System.Collections.Generic;

    using BGGAPI.Shared;

    /// <summary>
    /// The statistics for the thing item.
    /// <see cref="Item"/> for parent object.
    /// <see cref="Ratings"/> for information about the rating.
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
}
