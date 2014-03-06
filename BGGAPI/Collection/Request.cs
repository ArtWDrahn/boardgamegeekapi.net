namespace BGGAPI.Collection
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Request details about a user's collection.
    /// Base URI: /xmlapi2/collection?parameters
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Specifies which collection you want to retrieve.
        /// TYPE may be boardgame, boardgameexpansion, rpgitem, videogame; the default is boardgame
        /// </summary>
        public enum Type
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
            RPGItem,

            /// <summary>
            /// Video Game
            /// </summary>
            VideoGame
        }

        /// <summary>
        /// Gets or sets the user name the collection request is for.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Version of the Collection Request.
        /// version=1  Returns version info for each item in your collection.
        /// </summary>
        /// TODO: Figure out what this is doing.
        // public bool? Version { get; set; }

        /// <summary>
        /// Gets or sets the type of collection to retrieve.
        /// </summary>
        public Type? SubType { get; set; }

        /// <summary>
        /// Gets or sets the type of collection to EXCLUDE.
        /// </summary>
        public Type? ExcludeSubType { get; set; }

        /// <summary>
        /// Gets or sets the id of the listed item.
        /// Maybe be a comma delaminated list of ids.
        /// </summary>
        public List<int> ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the results should be abbreviated.
        /// </summary>
        public bool Brief { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether expanded expanded rating/ranking should be returned for the collection.
        /// </summary>
        public bool Stats { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return owned items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Own { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return rated items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Rated { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return played items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Played { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return commented items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Comment { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return tradable items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Trade { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return wanted items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Want { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return wish listed items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? Wishlist { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return wish list priority. Returns only items of the specified priority.
        /// </summary>
        public int? WishlistPriority { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return want to play items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? WantToPlay { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return want to buy items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? WantToBuy { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return preowned items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? PreOwned { get; set; }

        /// <summary>
        /// Gets or sets if the list should just return has parts items (true), filter these items out (false) or return everything (null).
        /// </summary>
        public bool? HasParts { get; set; }

        /// <summary>
        /// Gets or sets the minimum personal rating for the collection.
        /// Decimal 1-10
        /// </summary>
        public int? MinRating { get; set; }

        /// <summary>
        /// Gets or sets the maximum personal rating for the collection.
        /// Decimal 1-10
        /// </summary>
        public int? MaxRating { get; set; }

        /// <summary>
        /// Gets or sets the minimum board game geek rating for the collection.
        /// Decimal 1-10
        /// </summary>
        public int? MinBGGRating { get; set; }

        /// <summary>
        /// Gets or sets the maximum board game geek rating for the collection.
        /// Decimal 1-10
        /// </summary>
        public int? MaxBGGRating { get; set; }

        /// <summary>
        /// Gets or sets the minimum plays for the collection.
        /// </summary>
        public int? MinPlays { get; set; }

        /// <summary>
        /// Gets or sets the maximum plays for the collection.
        /// </summary>
        public int? MaxPlays { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the private collection should be displayed.
        /// Only works when logged in as the user.
        /// </summary>
        /// TODO: Implement system to login as the user.
        // public bool ShowPrivate { get; set; }

        // If set, return only items with a status (own, want, fortrade etc) changed or added since this date. If null, return all items.   
        public DateTime? ModifiedSince { get; set; }
    }
}
