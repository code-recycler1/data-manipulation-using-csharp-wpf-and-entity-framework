namespace SingularRelationshipsExample_Models
{
    /// <summary>
    /// A static class that provides helper methods for numeric conversions.
    /// </summary>
    public static class Conversions
    {
        /// <summary>
        /// Converts a numeric value (double) to a string formatted with two decimal places.
        /// </summary>
        /// <param name="value">The numeric value to format.</param>
        /// <returns>A string representation of the value with two decimal places.</returns>
        public static string ConvertNumericToString(double value)
        {
            return value.ToString("0.00");
        }

        /// <summary>
        /// Converts a numeric value (double) to a currency-formatted string.
        /// The format depends on the system's culture settings.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>A string representation of the value in currency format.</returns>
        public static string ConvertNumericToCurrency(double value)
        {
            return value.ToString("C");
        }
    }
}
