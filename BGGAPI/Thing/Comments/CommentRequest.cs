// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommentRequest.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Comment Request type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace BGGAPI.Thing.Comments
{
    /// <summary>
    /// The comment request.
    /// </summary>
    public class CommentRequest : Request
    {
        /// <summary>
        /// Gets or sets if the list should just return the comments (true), filter these items out (false) or return everything (null).
        /// Also includes ratings when commented. See page parameter.
        /// </summary>
        public bool? Comments { get; set; }
    }
}
