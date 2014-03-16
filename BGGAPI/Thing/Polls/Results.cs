namespace BGGAPI.Thing.Polls
{
    using System.Collections.Generic;

    /// <summary>
    /// The results of the poll.
    /// </summary>
    public class Results
    {
        /// <summary>
        /// Gets or sets the number of players.
        /// Should only occur on a "Number of Players Poll"
        /// Has to be a string because values can be returned as "10+"
        /// </summary>
        public string NumPlayers { get; set; }

        /// <summary>
        /// Gets or sets the results.
        /// Called Result list because this class has to be called results.
        /// And I used ResultsList for the list of this class.
        /// </summary>
        public List<Result> ResultList { get; set; }
    }
}
