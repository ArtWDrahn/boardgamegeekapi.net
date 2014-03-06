namespace BGGAPI.Shared
{
    using System;

    /// <summary>
    /// Used when the api returns an XML with a value name.
    /// </summary>
    public class StringValue
    {
        public string value { get; set; }
    }

    public class IntValue
    {
        public int value { get; set; }
    }

    public class FloatValue
    {
        public float value { get; set; }
    }

    public class DateTimeValue
    {
        public DateTime value { get; set; }
    }

    public class MoneyValue
    {
        public string Currency { get; set; }
        public float value { get; set; }
    }

    public class LinkValue
    {
        /// <summary>
        /// Gets or sets the h ref.
        /// </summary>
        public string HRef { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }
    }
}
