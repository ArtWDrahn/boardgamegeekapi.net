// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Url.cs" company="Tyson J. Hayes">
//   © 2013 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The Board Game Geek sites contain a number of different sites with various titles in play.
//   The URLs to access these sites are listed below.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI
{
    /// <summary>
    /// The Board Game Geek sites contain a number of different sites with various titles in play.
    /// The URLs to access these sites are listed below.
    /// </summary>
    internal class Url
    {
        /// <summary>
        /// The board game geek url.
        /// </summary>
        public const string BoardGameUrl = "http://www.boardgamegeek.com/xmlapi2/";

        /// <summary>
        /// The roleplaying game geek url.
        /// </summary>
        public const string RpgGameUrl = "http://www.rpggeek.com/xmlapi2/";

        /// <summary>
        /// The video game geek url.
        /// </summary>
        public const string VideoGameUrl = "http://www.videogamegeek.com/xmlapi2";
    }
}
