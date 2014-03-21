// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Comment.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Comment Item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Comments
{
    /// <summary>
    /// Defines the Comment Item.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Gets or sets the user name for the comment.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the rating for the game in the comment.
        /// value can be 'n/a'
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        /// Gets or sets the value of the comment.
        /// This would be the comment itself.
        /// </summary>
        public string value { get; set; }
    }
}
