// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Result.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The result of an individual poll.
//   <see cref="Poll" /> for the highest poll object.
//   <see cref="Results" /> for the list of Results.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Polls
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The result of an individual poll.
    /// <see cref="Poll"/> for the highest poll object.
    /// <see cref="Results"/> for the list of Results.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Gets or sets the level.
        /// Expected to only be seen on language dependence poll. 
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// Has to be lower case for ReSharper to work.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
        public string value { get; set; }

        /// <summary>
        /// Gets or sets the number of votes on this pull.
        /// </summary>
        public int NumVotes { get; set; }
    }
}
