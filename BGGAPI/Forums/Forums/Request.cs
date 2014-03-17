// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Request object for the Forum API calls.
//   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
//   See <see cref="BGGAPI.Forums.Return" /> for the return response.
//   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Forums
{
    /// <summary>
    ///   Request object for the Forum API calls.
    ///   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
    ///   See <see cref="BGGAPI.Forums.Return" /> for the return response.
    ///   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Gets or sets the id of the forum.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the page for the forum.
        /// </summary>
        public int Page { get; set; }
    }
}
