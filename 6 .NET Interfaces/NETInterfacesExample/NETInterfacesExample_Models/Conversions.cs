namespace NETInterfacesExample_Models
{
    /// <summary>
    /// Provides helper methods for numeric conversions.
    /// </summary>
    public static class Conversions
    {
        /// <summary>
        /// Converts a numeric value to a string with two decimal places.
        /// </summary>
        public static string ConvertNumericToString(double value)
        {
            return value.ToString("0.00");
        }

        /// <summary>
        /// Converts a numeric value to a currency-formatted string.
        /// </summary>
        public static string ConvertNumericToCurrency(double value)
        {
            return value.ToString("C");
        }
    }
}
