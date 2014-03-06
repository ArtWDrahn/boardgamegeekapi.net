namespace BGGAPI.Thing
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request parameters for a thing.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// The page.
        /// </summary>
        private int page = 1;

        /// <summary>
        /// The page size.
        /// </summary>
        private int pageSize = 10;

        /// <summary>
        /// Specifies which thing you want to retrieve.
        /// </summary>
        public enum ThingType
        {
            /// <summary>
            /// BoardGame type. DEFAULT.
            /// </summary>
            BoardGame,

            /// <summary>
            /// Board Game Expansion
            /// </summary>
            BoardGameExpansion,

            /// <summary>
            /// RPG Item
            /// </summary>
            RpgItem,

            /// <summary>
            /// RPG Issue
            /// </summary>
            RpgIssue,

            /// <summary>
            /// Video Game
            /// </summary>
            VideoGame
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public List<int> ID { get; set; }

        /// <summary>
        /// Gets or sets the thing.
        /// </summary>
        public ThingType Thing { get; set; }

        /// <summary>
        /// Gets or sets the Pages to return.
        /// Defaults to 1.
        /// </summary>
        public int Page
        {
            get
            {
                return this.page;
            }

            set
            {
                this.page = value;
            }
        }

        /// <summary>
        /// Gets or sets the PageSize to return.
        /// Minimum is 10, Maximum is 100.
        /// </summary>
        public int PageSize
        {
            get
            {
                return this.pageSize;
            }

            set
            {
                if (Enumerable.Range(10, 100).Contains(value))
                {
                    this.pageSize = value;
                }
            }
        }

        // All items below do not return anything by default and are optional flags on a thing.
        #region Optional Things
        /// <summary>
        /// Gets or sets if the list should just return the version info (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Versions { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return the videos (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Videos { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return the stats (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Stats { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return the historical data (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Historical { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return the marketplace data (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Marketplace { get; set; }

        #endregion
    }
}
