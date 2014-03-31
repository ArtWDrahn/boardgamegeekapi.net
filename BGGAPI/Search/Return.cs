// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//  Defining the return object for the Search request..
//  <see cref="Request"/> for the request code.
//  <see cref="Return"/> for the returned object.
//  <see cref="Item"/> for the specific items returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Search
{
    using System.Collections.Generic;

    public class Return
    {
        public int Total { get; set; }

        public List<Item> Items { get; set; } 
    }
}
