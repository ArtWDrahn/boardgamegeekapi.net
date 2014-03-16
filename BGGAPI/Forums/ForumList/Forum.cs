// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Forum.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Forum type which is returned in the ForumList return object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.ForumList
{
    /// <summary>
    /// Defines the Forum type which is returned in the ForumList return object.
    /// </summary>
    public class Forum
    {
        /// <summary>
        /// Gets or sets the id for the forum being referenced.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the group id.
        /// Not sure what this is actually used for.
        /// </summary>
        public int GroupID { get; set; }

        /// <summary>
        /// Gets or sets the title of the forum.
        /// Example: Reviews.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether no posting flag has been set.
        /// It's assumed that this is used to lock forums.
        /// </summary>
        public bool NoPosting { get; set; }

        /// <summary>
        /// Gets or sets the description of the forum.
        /// Example: Post your session reports here.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the number of threads for the forum.
        /// </summary>
        public int NumThreads { get; set; }

        /// <summary>
        /// Gets or sets the number posts of posts on the forum.
        /// </summary>
        public int NumPosts { get; set; }

        /// <summary>
        /// Gets or sets the last post date for the forum.
        /// </summary>
        public string LastPostDate { get; set; }
    }
}
