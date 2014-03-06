// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommentReturn.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CommentReturn type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Comments
{
    using System.Collections.Generic;

    /// <summary>
    /// The Comments object returned.
    /// </summary>
    public class Return : Shared.Return
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }
    }

    /// <summary>
    /// The item.
    /// </summary>
    public class Item
    {
        public int ID { get; set; }

        public Comments Comments { get; set; }
    }

    public class Comments
    {
        public int Page { get; set; }

        public int TotalItems { get; set; }

        public List<Comment> CommentList { get; set; }
    }

    public class Comment
    {
        public string UserName { get; set; }

        // value can be 'n/a'
        public string Rating { get; set; }
 
        public string value { get; set; }
    }

    public class Request : Thing.Request
    {
        /// <summary>
        /// Gets or sets if the list should just return the comments (true), filter these items out (false) or return everything (null).
        /// Also includes ratings when commented. See page parameter.
        /// </summary>
        public bool? Comments { get; set; }
    }

    public class RequestRatings : Request
    {
        /// <summary>
        /// Gets or sets if the list should just return the rating comments (true), filter these items out (false) or return everything (null).
        /// the rating comments and comments parameters cannot be used together,
        /// as the output always appears in the comments node of the XML;
        /// comments parameter takes precedence if both are specified.
        /// Ratings are sorted in descending rating value,
        /// based on the highest rating they have assigned to that item (each item in the collection can have a different rating).
        /// </summary>
        /// TODO: Impliment this.
        public bool? RatingComments { get; set; }
    }
}
