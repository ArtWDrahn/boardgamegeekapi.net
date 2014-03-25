using System;
using System.Collections.Generic;

namespace BGGAPI.Threads
{
    public class Return : Shared.IReturn
    {
        public int TotalItems { get; set; }
        public string TermsOfUse { get; set; }

        public int ID { get; set; }

        public int NumArticles { get; set; }

        public Uri Link { get; set; }

        public string Subject { get; set; }

        public List<Article> Articles { get; set; }
    }

    public class Article
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public Uri Link { get; set; }

        public DateTime PostDate { get; set; }
    }
}
