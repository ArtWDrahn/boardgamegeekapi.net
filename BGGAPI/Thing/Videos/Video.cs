// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Video.cs" company="">
//   
// </copyright>
// <summary>
//   The video.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI.Thing.Videos
{
    using System;

    /// <summary>
    /// The video.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// The link backing field.
        /// </summary>
        private string link;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        public string Link
        {
            get
            {
                return this.link;
            }

            set
            {
                if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
                {
                    return;
                }

                this.link = value;
            }
        }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the post date.
        /// </summary>
        public DateTime PostDate { get; set; }
    }

}
