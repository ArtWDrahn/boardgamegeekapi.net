// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the CommentReturn type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Comments
{
    using System.Collections.Generic;

    /// <summary>
    /// The Comments object returned.
    /// </summary>
    public class Return : Shared.Return
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }
    }
}
