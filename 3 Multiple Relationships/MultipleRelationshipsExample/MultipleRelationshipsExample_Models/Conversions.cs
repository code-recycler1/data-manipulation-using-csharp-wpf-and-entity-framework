namespace MultipleRelationshipsExample_Models
{
    /// <summary>
    /// Provides utility methods for converting numeric values to formatted strings.
    /// </summary>
    public static class Conversions
    {
        /// <summary>
        /// Converts a numeric value to a string with two decimal places.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>A string representation of the value formatted to two decimal places.</returns>
        public static string ConvertNumericToString(double value)
        {
            return value.ToString("0.00");
        }

        /// <summary>
        /// Converts a numeric value to a currency-formatted string.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>A string representation of the value formatted as currency.</returns>
        public static string ConvertNumericToCurrency(double value)
        {
            return value.ToString("c");
        }
    }
}
