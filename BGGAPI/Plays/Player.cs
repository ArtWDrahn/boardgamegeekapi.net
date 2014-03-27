// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The returned object for plays for a user or an item.
//   This describes more detail about the play itself,
//   Including detail about the players.
//   <see cref="Return" /> for the returned object.
//   <see cref="Player" /> for the Player object.
//   <see cref="Play" /> for the Play object.
//   <see cref="Item" /> for the Item object.
//   <see cref="SubType" /> for the SubType object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Plays
{
    public class Player
    {
        public string UserName { get; set; }

        public int UserID { get; set; }

        public string Name { get; set; }

        public string StartPosition { get; set; }

        public string Color { get; set; }

        public int? Score { get; set; }

        public bool New { get; set; }

        public bool Win { get; set; }
    }
}