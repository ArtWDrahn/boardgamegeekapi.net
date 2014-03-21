// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//  The Request object for the ForumList.
//  <see cref="Request"/> for the request object.
//  <see cref="Return"/> for the return object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.ForumList
{
    /// <summary>
    /// The request object for the forum list.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// The family type.
        /// </summary>
        public enum FamilyType
        {
            thing,
            family
        }

        /// <summary>
        /// Gets or sets the id for the forum list.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the type being requested.
        /// </summary>
        public FamilyType Type { get; set; }
    }
}
