// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes" />
// <summary>
//   Used to request basic public profile information about a user by username.
//   The naming of this is questionable if the project wishes to allow a user to login via the API.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Users
{
    using System.Linq;

    /// <summary>
    /// The request for a user's information.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// The page default to return.
        /// </summary>
        private int page = 1;

        /// <summary>
        /// Controls the domain for the users hot 10 and top 10 lists. The DOMAIN default is boardgame.
        /// </summary>
        public enum Domain
        {
            boardgame,
            rpg,
            videogame
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether buddies should be returned.
        /// Results are paged and controlled by the page parameter.
        /// </summary>
        public bool Buddies { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether guilds should be returned.
        /// Results are paged and controlled by the page parameter.
        /// </summary>
        public bool Guilds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user's hot 10 list should be returned.
        /// Results are paged and controlled by the page parameter.
        /// </summary>
        public bool Hot { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user's top 10 list should be returned.
        /// Results are paged and controlled by the page parameter.
        /// </summary>
        public bool Top { get; set; }

        /// <summary>
        /// Gets or sets the pages to be returned.
        /// The page parameter controls paging for both buddies and guilds list if both are specified.
        /// If a buddies or guilds node is empty, it means that you have requested a page higher
        /// than that needed to list all the buddies/guilds or,
        /// if you're on page 1, it means that that user has no buddies and is not part of any guilds.
        /// </summary>
        public int Page
        {
            get
            {
                return this.page;
            }

            set
            {
                if (Enumerable.Range(1, 100).Contains(value))
                {
                    this.page = value;
                }
            }
        }
    }
}
