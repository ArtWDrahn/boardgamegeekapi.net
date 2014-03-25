// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
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
    using System;

    public class Return : Shared.IReturn
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public string Category { get; set; }

        public string WebSite { get; set; }

        public string Manager { get; set; }

        public string Description { get; set; }

        public Location Location { get; set; }

        public Members Members { get; set; }
        public int TotalItems { get; set; }
        public string TermsOfUse { get; set; }
    }
}
