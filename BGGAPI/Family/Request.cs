// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Request type for the Family Request.
//   In the BGG database, more abstract or esoteric concepts are represented by something called a family.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Family
{
    using System.Collections.Generic;

    public class Request
    {
        /// <summary>
        /// Declares the different types of families we can use.
        /// </summary>
        public enum FamilyType
        {
            /// <summary>
            /// The rpg family type.
            /// </summary>
            rpg,

            /// <summary>
            /// The rpgperiodical family type.
            /// </summary>
            rpgperiodical,

            /// <summary>
            /// The boardgamefamily family type.
            /// </summary>
            boardgamefamily
        }

        /// <summary>
        /// Gets or sets the id of the family to retrieve.
        /// To request multiple families with a single query,
        /// ID can specify a comma-delimited list of ids.
        /// </summary>
        public List<int> ID { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// Specifies that, regardless of the type of family asked for by id,
        /// the results are filtered by the FAMILYTPE(s) specified.
        /// Multiple FAMILYTYPEs can be specified in a comma-delimited list
        /// </summary>
        public List<FamilyType> Type { get; set; }
    }
}
