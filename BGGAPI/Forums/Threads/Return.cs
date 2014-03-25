// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Return.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the return object returned in <see cref="Request" />
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Threads
{
    using System;
    using System.Collections.Generic;

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
}
