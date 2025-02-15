namespace StaticsExample_Models
{
    /// <summary>
    /// Static class to store application-wide settings.
    /// </summary>
    public static class PersonalSettings
    {
        /// <summary>
        /// The folder where output files (e.g., logs) should be saved.
        /// If empty, files will be saved in the application's bin\debug folder.
        /// </summary>
        public static string OutputFolder = "";

        /// <summary>
        /// The currency symbol to use for displaying amounts.
        /// Default is "€" (Euro).
        /// </summary>
        public static string Currency = "€";
    }
}