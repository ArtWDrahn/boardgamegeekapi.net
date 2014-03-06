namespace BGGAPI.Users
{
    using System.Collections.Generic;

    using BGGAPI.Shared;

    public class UserReturn
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public StringValue FirstName { get; set; }

        public StringValue LastName { get; set; }

        public StringValue AvatarLink { get; set; }

        public StringValue YearRegistered { get; set; }

        public DateTimeValue LastLogin { get; set; }

        public StringValue StateOrProvince { get; set; }

        public StringValue Country { get; set; }

        public StringValue WebAddress { get; set; }

        public StringValue XboxAccount { get; set; }

        public StringValue WiiAccount { get; set; }

        public StringValue PSNAccount { get; set; }

        public StringValue BattleNetAccount { get; set; }

        public StringValue SteamAccount { get; set; }

        public IntValue TradeRating { get; set; }

        public Top Top { get; set; }

        public Hot Hot { get; set; }

        public Buddies Buddies { get; set; }

        public Guilds Guilds { get; set; }
    }

    /// <summary>
    /// Class for the Users Top List
    /// </summary>
    public class Top
    {
        public string Domain { get; set; }

        public List<Item> Items { get; set; } 
    }

    /// <summary>
    /// Class for the User's Hot list.
    /// </summary>
    public class Hot
    {
        public string Domain { get; set; }

        public List<Item> Items { get; set; }
    }

    /// <summary>
    /// Class denoting the items in the list.
    /// </summary>
    public class Item
    {
        public int Rank { get; set; }

        public string Type { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }
    }

    public class Buddies
    {
        public int Total { get; set; }

        public int Page { get; set; }

        public List<Buddy> BuddyList { get; set; } 
    }

    public class Buddy
    {
        public int ID { get; set; }

        public string Name { get; set; }

    }

    public class Guilds
    {
        public int Total { get; set; }

        public int Page { get; set; }

        public List<Guild> GuildList { get; set; } 
    }

    public class Guild
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
