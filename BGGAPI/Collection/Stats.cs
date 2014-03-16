namespace BGGAPI.Collection
{
    using BGGAPI.Shared;

    /// <summary>
    /// The stats of a particular game.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Gets or sets the min players.
        /// </summary>
        public int MinPlayers { get; set; }

        /// <summary>
        /// Gets or sets the max players.
        /// </summary>
        public int MaxPlayers { get; set; }

        /// <summary>
        /// Gets or sets the playing time.
        /// </summary>
        public int PlayingTime { get; set; }

        /// <summary>
        /// Gets or sets the number owned.
        /// </summary>
        public int NumOwned { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public Ratings Rating { get; set; }
    }
}
