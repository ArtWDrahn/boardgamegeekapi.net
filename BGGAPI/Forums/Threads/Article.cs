// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Article.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the article object returned in <see cref="Return" />
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Threads
{
    using System;

    public class Article
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public Uri Link { get; set; }

        public DateTime PostDate { get; set; }

        public int NumEdits { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
