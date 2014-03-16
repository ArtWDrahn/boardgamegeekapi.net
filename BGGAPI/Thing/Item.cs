// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   The object describing the thing being returned.
//   <see cref="Request"/> for the request for this object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing
{
    using System;
    using System.Collections.Generic;

    using BGGAPI.Shared;
    using BGGAPI.Thing.Polls;

    /// <summary>
    /// The object describing the thing being returned.
    /// <see cref="Request"/> for the request for this object.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The thumbnail backing field.
        /// </summary>
        private string thumbnail;

        /// <summary>
        /// The image backing field.
        /// </summary>
        private string image;

        /// <summary>
        /// Gets or sets the type of item.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id for the item.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public List<Name> Names { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail.
        /// This should always be a URI returned.
        /// </summary>
        public string Thumbnail
        {
            get
            {
                return this.thumbnail;
            }

            set
            {
                if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
                {
                    return;
                }

                this.thumbnail = value;
            }
        }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public string Image
        {
            get
            {
                return this.image;
            }

            set
            {
                if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
                {
                    return;
                }

                this.image = value;
            }
        }

        /// <summary>
        /// Gets or sets the year published.
        /// </summary>
        public StringValue YearPublished { get; set; }

        /// <summary>
        /// Gets or sets the min players.
        /// </summary>
        public IntValue MinPlayers { get; set; }

        /// <summary>
        /// Gets or sets the max player.
        /// </summary>
        public IntValue MaxPlayers { get; set; }

        /// <summary>
        /// Gets or sets the playing time.
        /// </summary>
        public IntValue PlayingTime { get; set; }

        /// <summary>
        /// Gets or sets the min age.
        /// </summary>
        public IntValue MinAge { get; set; }

        /// <summary>
        /// Gets or sets the Polls for the item.
        /// </summary>
        public List<Poll> Polls { get; set; }

        /// <summary>
        /// Gets or sets the links for the thing.
        /// </summary>
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the videos.
        /// </summary>
        public VideosList Videos { get; set; }

        /// <summary>
        /// Gets or sets the statistics.
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// Gets or sets the marketplace listings.
        /// </summary>
        public MarketplaceListings MarketplaceListings { get; set; }
    }
}
