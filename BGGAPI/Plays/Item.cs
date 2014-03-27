// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The item object for plays for a user or an item.
//   This describes the game being played in more detail.
//   <see cref="Return" /> for the returned object.
//   <see cref="Player" /> for the Player object.
//   <see cref="Play" /> for the Play object.
//   <see cref="Item" /> for the Item object.
//   <see cref="SubType" /> for the SubType object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Plays
{
    using System.Collections.Generic;

    public class Item
    {
        /// <summary>
        /// Gets or sets the object type.
        /// Only have seen "thing" listed in the XML
        /// </summary>
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the object id.
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the name of the game.
        /// </summary>
        public string Name { get; set; }

        public List<SubType> SubTypes { get; set; }  
    }
}