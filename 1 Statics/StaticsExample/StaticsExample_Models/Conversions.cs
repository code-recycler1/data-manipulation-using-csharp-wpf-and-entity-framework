namespace StaticsExample_Models
{
    /// <summary>
    /// Static class for currency conversion and formatting.
    /// </summary>
    public static class Conversions
    {
        public static double ExchangeRate = 1.0999; // Exchange rate for USD to EUR

        /// <summary>
        /// Converts a numeric value to a formatted string with two decimal places.
        /// </summary>
        public static string ConvertNumericToString(double value)
        {
            return value.ToString("0.00");
        }

        /// <summary>
        /// Converts an amount based on the selected currency.
        /// </summary>
        public static double ConvertAmount(double amount)
        {
            return PersonalSettings.Currency == "€" ? amount : ExchangeRate * amount;
        }

        /// <summary>
        /// Converts a numeric value to a currency-formatted string.
        /// </summary>
        public static string ConvertNumericToCurrency(double value)
        {
            return $"{PersonalSettings.Currency} {ConvertNumericToString(value)}";
        }
    }
}