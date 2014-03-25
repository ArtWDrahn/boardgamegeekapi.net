namespace BGGAPI.Shared
{
    public interface IReturn
    {
        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the terms of use.
        /// </summary>
        string TermsOfUse { get; set; }
    }
}
