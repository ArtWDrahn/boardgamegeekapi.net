// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The request for plays for a user or an item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Plays
{
    /// <summary>
    /// The request for plays for a user or an item.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Used to filter the types of plays.
        /// Unclear how you can play a family type.
        /// </summary>
        public enum FamilyType
        {
            thing,
            family,
        }

        /// <summary>
        /// This is used to filter the sub types to these sub types.
        /// This is not exclusionary so it'll findsomething that is both
        /// a board game and expansion not just one.
        /// </summary>
        public enum FamilySubType
        {
            /// <summary>
            /// A board game.
            /// </summary>
            boardgame,

            /// <summary>
            /// An Expansion
            /// </summary>
            boardgamexpansion,
            
            /// <summary>
            /// This appears for a couple of games such as Formula D.
            /// Unclear as it's meaning but putting it here as it seems
            ///  to be an undocumented sub type.
            /// </summary>
            boardgameimplemntation,

            /// <summary>
            /// RPG Itmes
            /// </summary>
            rpgitem,

            /// <summary>
            /// Video Games
            /// </summary>
            videogame,
        }

        /// <summary>
        /// The name of the user to run the query on.
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// This ID is for the game itself.
        /// This will be object id in the return item.
        /// </summary>
        public int? ID { get; set; }

        public FamilyType? Type { get; set; }

        public FamilySubType? SubType { get; set; }

        /// <summary>
        /// Page size is 100 records.
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// Needs to bein the YYYY-MM-DD format.
        /// </summary>
        public string MinDate { get; set; }

        /// <summary>
        /// Needs to bein the YYYY-MM-DD format.
        /// </summary>
        public string MaxDate { get; set; }
    }
}