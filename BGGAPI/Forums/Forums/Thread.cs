// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Thread.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Thread object for the Forum API calls.
//   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
//   See <see cref="BGGAPI.Forums.Return" /> for the return response.
//   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Forums
{
    using System;

    /// <summary>
    ///   Thread object for the Forum API calls.
    ///   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
    ///   See <see cref="BGGAPI.Forums.Return" /> for the return response.
    ///   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
    /// </summary>
    public class Thread
    {
        /// <summary>
        /// Gets or sets the id of the thread.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the subject of the thread.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the author of the thread.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the number of articles for the thread.
        /// </summary>
        public int NumArticles { get; set; }

        /// <summary>
        /// Gets or sets the post date of the thread.
        /// </summary>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// Gets or sets the last post date of the thread.
        /// </summary>
        public DateTime LastPostDate { get; set; }
    }
}
