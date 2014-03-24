// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The return object for Board Game Geek Guilds.
//   This is the list object for the members.
//   <see cref="Request" /> for request object.
//   <see cref="Return" /> for the request object that links to this.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Guilds
{
    using System.Collections.Generic;

    public class Members
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public List<Member> List { get; set; } 
    }
}