// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The returned object for plays for a user or an item.
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

    /// <summary>
    ///  The returned object for plays for a user or an item.
    ///   <see cref="Return" /> for the returned object.
    ///   <see cref="Player" /> for the Player object.
    ///   <see cref="Play" /> for the Play object.
    ///   <see cref="Item" /> for the Item object.
    ///   <see cref="SubType" /> for the SubType object.
    /// </summary>
    public class Return

    {
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The users numerical ID.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// The total amount of plays the user has.
        /// This can be used to determine how many pages need to be returned.
        /// Thus if a user has 298 plays, 3 pages would need to be queried to get everything.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// The Page that is being returned.
        /// </summary>
        public int Page { get; set; }

        public List<Play> Plays { get; set; } 
    }
}
