namespace BGGAPI.Plays
{
    using System;
    using System.Collections.Generic;

    public class Return

    {
        /// <summary>
        /// The name of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The users numerical ID.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// The total amount of plays the user has.
        /// This can be used to determine how many pages need to be returned.
        /// Thus if a user has 298 plays, 3 pages would need to be queried to get everything.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// The Page that is being returned.
        /// </summary>
        public int Page { get; set; }

        public List<Play> Plays { get; set; } 
    }

    public class Play
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public int Length { get; set; }

        public int Incomplete { get; set; }

        public bool NoWinStats { get; set; }

        public string Location { get; set; }

        public Item Item { get; set; }

        public List<Player> Players { get; set; }
    }

    public class Item
    {
        /// <summary>
        /// Gets or sets the object type.
        /// Only have seen "thing" listed in the XML
        /// </summary>
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the object id.
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the name of the game.
        /// </summary>
        public string Name { get; set; }

        public List<SubType> SubTypes { get; set; }  
    }

    public class Player
    {
        //<player username="tysonjhayes" userid="559070" name="Tyson" startposition="1" color="" score="" new="0" rating="0" win="0"/
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }

        public int StartPosition { get; set; }

        public string Color { get; set; }

        public int Score { get; set; }

        public bool New { get; set; }

        public bool Win { get; set; }
    }

    public class SubType
    {
        public string value { get; set; }
    }
}
