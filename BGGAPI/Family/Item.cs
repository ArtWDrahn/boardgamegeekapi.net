// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the return type for the Family Request.
//   In the BGG database, more abstract or esoteric concepts are represented by something called a family.
//   This handles the individual items in the list that is returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Family
{
    using System.Collections.Generic;

    using BGGAPI.Shared;

    /// <summary>
    /// The item object that is returned.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the names of the family item that is returned.
        /// </summary>
        public List<Name> Names { get; set; }

        /// <summary>
        /// Gets or sets the description of the family item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image Url for the family item.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail for the family item.
        /// </summary>
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the links for the family item.
        /// These links can be parsed for the thing id for more details about the family.
        /// </summary>
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the Type returned.
        /// This should match the Family.Request.Type specified.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the ID returned.
        /// This should match the Family.Request.ID specified.
        /// </summary>
        public int ID { get; set; }
    }

    public class Link
    {
        public string Type { get; set; }

        public int ID { get; set; }

        public string value { get; set; }

        /// <summary>
        /// Gets or sets the inbound link.
        /// </summary>
        public string Inbound { get; set; }
    }
}
