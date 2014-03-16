//-----------------------------------------------------------------------
// <copyright file="Object.cs" company="Tyson J. Hayes">
//     © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary> Collection object for BGG API </summary>
//-----------------------------------------------------------------------

namespace BGGAPI.Collection
{
    using System.Collections.Generic;

    /// <summary>
    /// The collection object.
    /// </summary>
    public class Return
    {
        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the terms of use.
        /// </summary>
        public string TermsOfUse { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }
    }
}
