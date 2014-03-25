// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Sets up the request for Threads.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Threads
{
    using System;

    public class Request
    {
        private string _minArticleDate;

        public int ID { get; set; }

        public int MinArticleID { get; set; }

        // minarticledate=YYYY-MM-DD
        // minarticledate=YYYY-MM-DD%20HH%3AMM%3ASS
        public string MinArticleDate
        {
            get { return _minArticleDate; }
            set
            {
                DateTime date2;
                if (DateTime.TryParse(value, out date2))
                {
                    _minArticleDate = value;
                }
            }
        }

        // Limits the number of articles returned to no more than NNN.
        public int Count { get; set; }

        // Not supported yet.
        // public string UserName { get; set; }
    }
}
