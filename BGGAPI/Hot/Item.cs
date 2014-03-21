// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The returned hot item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Hot
{
    /// <summary>
    /// The item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        public Thumbnail Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public Name Name { get; set; }
    }
}
