// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The request object for Board Game Geek Guilds.
//   <see cref="Return" /> for returned object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Guilds
{
    public class Request
    {
        public enum SortType
        {
            username,
            date
        }

        /// <summary>
        /// Gets or sets the id of the guild you want to view.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether members should be included.
        /// Include member roster in the results. Member list is paged and sorted.
        /// </summary>
        public bool Members { get; set; }

        /// <summary>
        /// Gets or sets the sort of the member list.
        /// </summary>
        public SortType Sort { get; set; }

        /// <summary>
        /// Gets or sets the page of the member list to return.
        /// Page size is 25.
        /// </summary>
        public int Page { get; set; }
    }
}
