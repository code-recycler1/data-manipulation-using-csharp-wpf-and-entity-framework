using System;
using System.IO;

namespace EF_CUD_Example_DAL
{
    /// <summary>
    /// Provides file-related operations, such as logging errors to a file.
    /// </summary>
    class FileOperations
    {
        /// <summary>
        /// Logs error details to a file named "error_log.txt".
        /// </summary>
        /// <param name="error">The exception to be logged.</param>
        public static void LogError(Exception error)
        {
            using (StreamWriter writer = new StreamWriter("error_log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
                writer.WriteLine(error.GetType().Name);
                writer.WriteLine(error.Message);
                writer.WriteLine(error.StackTrace);
                writer.WriteLine(new string('-', 80));
                writer.WriteLine();
            }
        }
    }
}
