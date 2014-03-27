// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The returned object for plays for a user or an item.
//   This describes more detail about the play itself.
//   <see cref="Return" /> for the returned object.
//   <see cref="Player" /> for the Player object.
//   <see cref="Play" /> for the Play object.
//   <see cref="Item" /> for the Item object.
//   <see cref="SubType" /> for the SubType object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Plays
{
    using System;
    using System.Collections.Generic;

    public class Play
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public int Length { get; set; }

        public int Incomplete { get; set; }

        public bool NoWinStats { get; set; }

        public string Location { get; set; }

        public Item Item { get; set; }

        public List<Player> Players { get; set; }

        public string Comments { get; set; }
    }
}