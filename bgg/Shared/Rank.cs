namespace BGGAPI.Shared
{
    /// <summary>
    /// The rank.
    /// </summary>
    public class Rank
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the friendly name.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// This can return "Not Ranked" so needs to be a string rather than an integer
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Gets or sets the bayes average.
        /// This can return "Not Ranked" so needs to be a string rather than an integer
        /// </summary>
        public string BayesAverage { get; set; }
    }
}
