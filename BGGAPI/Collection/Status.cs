namespace BGGAPI
{
    using System;

    /// <summary>
    /// The status of the game.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Gets or sets the own.
        /// </summary>
        public int Own { get; set; }

        /// <summary>
        /// Gets or sets the previously owned.
        /// </summary>
        public int PreviouslyOwned { get; set; }

        /// <summary>
        /// Gets or sets the for trade.
        /// </summary>
        public int ForTrade { get; set; }

        /// <summary>
        /// Gets or sets the want.
        /// </summary>
        public int Want { get; set; }

        /// <summary>
        /// Gets or sets the want to play.
        /// </summary>
        public int WantToPlay { get; set; }

        /// <summary>
        /// Gets or sets the wish list priority.
        /// </summary>
        public int WishListPriority { get; set; }

        /// <summary>
        /// Gets or sets the pre ordered.
        /// </summary>
        public int PreOrdered { get; set; }

        /// <summary>
        /// Gets or sets the last modified.
        /// </summary>
        public string LastModified { get; set; }
    }
}
