// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the return type for the Family Request.
//   In the BGG database, more abstract or esoteric concepts are represented by something called a family.
//   This handles the object that is returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Family
{
    using System.Collections.Generic;

    /// <summary>
    /// The returned Family Object list.
    /// </summary>
    public class Return : Shared.IReturn
    {
        /// <summary>
        /// Gets or sets the items that are returned.
        /// </summary>
        public List<Item> Items { get; set; }

        public int TotalItems { get; set; }
        public string TermsOfUse { get; set; }
    }
}
