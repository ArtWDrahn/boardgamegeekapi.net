// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The links for the thing.
//   <see cref="Item" /> for the parent object of this class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing
{
    /// <summary>
    /// The links for the thing.
    /// <see cref="Item"/> for the parent object of this class.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string value { get; set; }
    }
}
