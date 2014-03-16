namespace BGGAPI.ForumList
{
    using System.Collections.Generic;

    /// <summary>
    /// The returned object of the ForumList call.
    /// </summary>
    public class Return : Shared.Return
    {
        /// <summary>
        /// Gets or sets the id of the returned forum list.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the type of the returned forum list.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the specific forums returned in the list.
        /// </summary>
        public List<Forum> Forums { get; set; }
    }
}
