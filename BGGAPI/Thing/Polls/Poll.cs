namespace BGGAPI.Thing.Polls
{
    using System.Collections.Generic;

    /// <summary>
    /// The polls that have been returned.
    /// </summary>
    public class Poll
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the total votes.
        /// </summary>
        public int TotalVotes { get; set; }

        /// <summary>
        /// Gets or sets the poll list.
        /// As there are typically more then one poll being returned multiple polls are needed.
        /// </summary>
        public List<Results> ResultsList { get; set; }
    }
}
