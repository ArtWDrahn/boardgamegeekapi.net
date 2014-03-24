// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The location object for Board Game Geek Guilds.
//   <see cref="Request" /> for request object.
//   <see cref="Members" /> for the list of members.
//   <see cref="Member"/> for the individual member objects.
//   <see cref="Locaton" /> for the location information of the guild.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Guilds
{
    public class Location
    {
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public int? PostalCode { get; set; }
        public string Country { get; set; }
    }
}