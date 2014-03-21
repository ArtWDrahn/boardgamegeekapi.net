// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The hot item request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Hot
{
    /// <summary>
    /// The hot item request.
    /// </summary>
    public class Request
    {
        public enum FamilyType
        {
            boardgame,
            rpg,
            videogame,
            boardgameperson,
            boardgamecompany,
            rpgcompany,
            videogamecompany,
        }

        /// <summary>
        /// Gets or sets the type of hot item.
        /// </summary>
        public FamilyType Type { get; set; }
    }
}
