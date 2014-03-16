// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Poll.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The polls that have been returned with the thing request.
//   <see cref="Request" /> for the Request object.
//   <see cref="Item" /> for the item object this should be linked to.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Polls
{
    using System.Collections.Generic;

    /// <summary>
    /// The polls that have been returned with the thing request.
    /// <see cref="Request"/> for the Request object.
    /// <see cref="Item"/> for the item object this should be linked to.
    /// <see cref="Results"/> for the results of the poll.
    /// </summary>
    public class Poll
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the total votes.
        /// </summary>
        public int TotalVotes { get; set; }

        /// <summary>
        /// Gets or sets the poll list.
        /// As there are typically more then one poll being returned multiple polls are needed.
        /// </summary>
        public List<Results> ResultsList { get; set; }
    }
}
