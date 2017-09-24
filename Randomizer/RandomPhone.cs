namespace Randomizer
{
    /// <summary>
    /// Randomizes phone numbers according to specified criteria.
    /// </summary>
    public static class RandomPhone
    {
        /// <summary>
        /// Randomizes a typical NA phone number, formatted with parenthesis around the area code and separating the
        /// prefix and line number with a hyphen.
        /// </summary>
        /// <param name="includeCountryCode">Includes the +1 country code at the start of the number if <c>true</c>, else only randomizes the ten digit phone number.</param>
        /// <returns>A randomized NA phone number.</returns>
        /// <remarks>
        /// See the Wiki entry on NANP for more information. https://en.wikipedia.org/wiki/North_American_Numbering_Plan
        /// </remarks>
        public static string NorthAmerica(bool includeCountryCode = false)
        {
            string phone = $"({RandomString.NumberOfLength(3)}){RandomString.NumberOfLength(3)}-{RandomString.NumberOfLength(4)}";
            if (includeCountryCode)
            {
                phone = $"+1{phone}";
            }
            return phone;
        }
    }
}
