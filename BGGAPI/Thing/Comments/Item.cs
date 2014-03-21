// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Comment List.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Comments
{
    using System.Collections.Generic;

    /// <summary>
    /// The item returned for the comment.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public List<Comment> Comments { get; set; }
    }
}
