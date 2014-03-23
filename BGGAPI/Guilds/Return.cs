namespace BGGAPI.Guilds
{
    using System;
    using System.Collections.Generic;

    public class Return : Shared.Return
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public string Category { get; set; }

        public string WebSite { get; set; }

        public string Manager { get; set; }

        public string Description { get; set; }

        public Location Location { get; set; }

        public Members Members { get; set; }
    }

    public class Location
    {
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public int? PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Members
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public List<Member> List { get; set; } 
    }

    public class Member
    {
        public string Name { get; set; }
        public string Date { get; set; }
    }
}
