namespace BGGAPI.Shared
{
    using System;

    /// <summary>
    /// Used when the api returns an XML with a value.
    /// In order to pick this up we have to have a property called value.
    /// Example: <name value = "Carcassone">
    /// </summary>
    public class StringValue
    {
        /// <summary>
        /// Gets or sets the value of the string.
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// The integer value.
    /// </summary>
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
        /// Gets or sets the hyper link for the link.
        /// </summary>
        public string HRef { get; set; }

        /// <summary>
        /// Gets or sets the title of the think.
        /// </summary>
        public string Title { get; set; }
    }

    /// <summary>
    /// The name of the Item.
    /// </summary>
    public class Name
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the sort index.
        /// </summary>
        public int SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string value { get; set; }
    }
}
