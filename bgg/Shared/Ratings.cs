namespace BGGAPI.Shared
{
    using System.Collections.Generic;

    /// <summary>
    /// The ratings.
    /// </summary>
    public class Ratings
    {
        /// <summary>
        /// Gets or sets the value.
        /// Doesn't work if this is called "Value"
        /// - see https://groups.google.com/forum/#!topic/restsharp/eAqzFFM13ns
        /// This can return "N/A" so needs to be a string rather than an integer
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Gets or sets the users rated.
        /// </summary>
        public IntValue UsersRated { get; set; }

        /// <summary>
        /// Gets or sets the average.
        /// </summary>
        public FloatValue Average { get; set; }

        /// <summary>
        /// Gets or sets the bayes average.
        /// </summary>
        public FloatValue BayesAverage { get; set; }

        /// <summary>
        /// Gets or sets the ranks.
        /// </summary>
        public List<Rank> Ranks { get; set; }

        /// <summary>
        /// Gets or sets the standard deviation.
        /// </summary>
        public FloatValue StdDev { get; set; }

        /// <summary>
        /// Gets or sets the median.
        /// </summary>
        public IntValue Median { get; set; }

        /// <summary>
        /// Gets or sets the owned.
        /// </summary>
        public IntValue Owned { get; set; }

        /// <summary>
        /// Gets or sets the trading.
        /// </summary>
        public IntValue Trading { get; set; }

        /// <summary>
        /// Gets or sets the wanting.
        /// </summary>
        public IntValue Wanting { get; set; }

        /// <summary>
        /// Gets or sets the wishing.
        /// </summary>
        public IntValue Wishing { get; set; }

        /// <summary>
        /// Gets or sets the number of comments.
        /// </summary>
        public IntValue NumComments { get; set; }

        /// <summary>
        /// Gets or sets the number of weights.
        /// </summary>
        public IntValue NumWeights { get; set; }

        /// <summary>
        /// Gets or sets the average weight.
        /// </summary>
        public FloatValue AverageWeight { get; set; }
    }
}
