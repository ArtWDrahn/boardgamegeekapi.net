//-----------------------------------------------------------------------
// <copyright file="Object.cs" company="Tyson J. Hayes">
//     Copyright (c), Tyson J. Hayes. All rights reserved.
// </copyright>
// <summary> Collection object for BGG API </summary>
// <author> tyson@justhayes.me </author>
//-----------------------------------------------------------------------


namespace BGGAPI.Collection
{
    using System.Collections.Generic;

    /// <summary>
    /// The collection object.
    /// </summary>
    public class Collection
    {
        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the terms of use.
        /// </summary>
        public string TermsOfUse { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<Item> Items { get; set; }
    }
}
