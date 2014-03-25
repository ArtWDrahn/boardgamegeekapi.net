using System;

namespace BGGAPI.Threads
{
    public class Request
    {
        public int ID { get; set; }

        public int MinArticleID { get; set; }

        // minarticledate=YYYY-MM-DD
        // minarticledate=YYYY-MM-DD%20HH%3AMM%3ASS
        public DateTime MinArticleDate { get; set; }

        // Limits the number of articles returned to no more than NNN.
        public int Count { get; set; }

        // Not supported yet.
        // public string UserName { get; set; }
    }
}
