// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//  Defining the request object for the Search request.
//  <see cref="Request"/> for the request code.
//  <see cref="Return"/> for the returned object.
//  <see cref="Item"/> for the specific items returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Search
{
    public class Request
    {
        public string Query { get; set; }

        public string Type { get; set; }

        public bool Exact { get; set; }
    }
}
