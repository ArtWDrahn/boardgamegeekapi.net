// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The return object for Board Game Geek Guilds.
//   This is mostly names, addresses and members names.
//   <see cref="Request" /> for request object.
//   <see cref="Members" /> for the list of members.
//   <see cref="Member"/> for the individual member objects.
//   <see cref="Locaton" /> for the location information of the guild.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Guilds
{
    public class Member
    {
        public string Name { get; set; }
        public string Date { get; set; }
    }
}