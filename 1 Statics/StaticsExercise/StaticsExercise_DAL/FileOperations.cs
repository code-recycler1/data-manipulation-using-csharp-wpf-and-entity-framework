using System;
using System.IO;

namespace StaticsExercise_DAL
{
    /// <summary>
    /// Static class for file operations.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// Logs errors to a file.
        /// </summary>
        public static void LogErrors(Exception error)
        {
            using (StreamWriter writer = new StreamWriter("errorlog.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
                writer.WriteLine(error.GetType().Name);
                writer.WriteLine(error.Message);
                writer.WriteLine(error.StackTrace);
                writer.WriteLine(new String('-', 80));
                writer.WriteLine();
            }
        }
    }
}