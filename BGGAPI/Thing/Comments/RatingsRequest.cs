// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RatingsRequest.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Ratings Request type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace BGGAPI.Thing.Comments
{
    /// <summary>
    /// The ratings request.
    /// </summary>
    public class RatingsRequest : Request
    {
        /// <summary>
        /// Gets or sets if the list should just return the rating comments (true), filter these items out (false) or return everything (null).
        /// the rating comments and comments parameters cannot be used together,
        /// as the output always appears in the comments node of the XML;
        /// comments parameter takes precedence if both are specified.
        /// Ratings are sorted in descending rating value,
        /// based on the highest rating they have assigned to that item (each item in the collection can have a different rating).
        /// </summary>
        public bool? RatingComments { get; set; }
    }
}
