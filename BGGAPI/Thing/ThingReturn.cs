// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThingReturn.cs" company="Tyson J. Hayes" />
// <summary>
//   The returned thing object
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing
{
    using System.Collections.Generic;

    using BGGAPI.Shared;

    /// <summary>
    /// The object that is returned when a request is made for a thing.
    /// </summary>
    public class Return : Shared.Return
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }
    }

    /// <summary>
    /// The object describing the thing being returned.
    /// </summary>
    public class Item
    {
        public string Type { get; set; }

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
        /// </summary>
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public string Image { get; set; }

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
        /// Gets or sets the suggested number of players.
        /// </summary>
        public List<Poll> Polls { get; set; }

        /// <summary>
        /// Gets or sets the playing time.
        /// </summary>
        public IntValue PlayingTime { get; set; }

        /// <summary>
        /// Gets or sets the min age.
        /// </summary>
        public IntValue MinAge { get; set; }

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

    /// <summary>
    /// The name of the Item.
    /// </summary>
    public class Name
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the sort index.
        /// </summary>
        public int SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string value { get; set; }
    }

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
        public List<Results> PollList { get; set; }
    }

    /// <summary>
    /// The results of the poll.
    /// </summary>
    public class Results
    {
        /// <summary>
        /// Gets or sets the number of players.
        /// Should only occur on a "Number of Players Poll"
        /// </summary>
        public string NumPlayers { get; set; }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        public List<Result> ResultsList { get; set; }
    }

    /// <summary>
    /// The result of an individual poll.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        public string Level { get; set; }

        public string value { get; set; }

        /// <summary>
        /// Gets or sets the num votes.
        /// </summary>
        public string NumVotes { get; set; }
    }

    /// <summary>
    /// The links for the thing.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string value { get; set; }
    }
}
