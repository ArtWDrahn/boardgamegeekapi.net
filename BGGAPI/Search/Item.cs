// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//  Defining the specific item returned for the Search request.
//  <see cref="Request"/> for the request code.
//  <see cref="Return"/> for the returned object.
//  <see cref="Item"/> for the specific items returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Search
{
    using Shared;

    public class Item
    {
        public string Type { get; set; }

        public int ID { get; set; }

        public Name Name { get; set; }

        public StringValue YearPublished { get; set; }
    }
}