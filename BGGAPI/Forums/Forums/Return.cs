// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Return object for the Forum API calls.
//   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
//   See <see cref="BGGAPI.Forums.Return" /> for the return response.
//   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Forums
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///   Return object for the Forum API calls.
    ///   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
    ///   See <see cref="BGGAPI.Forums.Return" /> for the return response.
    ///   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
    /// </summary>
    public class Return : Shared.Return
    {
        /// <summary>
        /// Gets or sets the id of the forum.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the title of the forum.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the number of threads for the forum.
        /// </summary>
        public int NumThreads { get; set; }

        /// <summary>
        /// Gets or sets the number of posts for the forum.
        /// </summary>
        public int NumPosts { get; set; }

        /// <summary>
        /// Gets or sets the last post date for the forum.
        /// Testing is showing this seems to be set to January 1, 1970 00:00:00
        /// Not sure if this is actually interesting to return. 
        /// </summary>
        public DateTime LastPostDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether posting is allowed.
        /// </summary>
        public bool NoPosting { get; set; }

        /// <summary>
        /// Gets or sets the threads returned in the call.
        /// </summary>
        public List<Thread> Threads { get; set; } 
    }
}
