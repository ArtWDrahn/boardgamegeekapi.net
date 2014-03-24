// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Statistics.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The statistics for the thing item.
//   <see cref="Item" /> for parent object.
//   <see cref="Rating" /> for information about the rating.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing
{
    using System.Collections.Generic;

    using Shared;

    /// <summary>
    /// The statistics for the thing item.
    /// <see cref="Item"/> for parent object.
    /// <see cref="Rating"/> for information about the rating.
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
        public List<Ratings> Rating { get; set; }
    }
}
