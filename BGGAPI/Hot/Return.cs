// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The returned hot list.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Hot
{
    using System.Collections.Generic;

    public class Return : Shared.IReturn
    {
        public List<Item> Items { get; set; }
        public int TotalItems { get; set; }
        public string TermsOfUse { get; set; }
    }
}
