namespace StaticsExercise_Models
{
    /// <summary>
    /// Static class for utility methods related to numeric conversions.
    /// </summary>
    public static class Conversions
    {
        /// <summary>
        /// Converts a numeric value to a formatted string with two decimal places.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <returns>A string representation of the value with two decimal places.</returns>
        public static string ConvertNumericToString(double value)
        {
            return value.ToString("0.00");
        }
    }
}
