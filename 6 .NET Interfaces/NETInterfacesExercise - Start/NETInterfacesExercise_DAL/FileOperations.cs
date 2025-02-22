using NETInterfacesExercise_Models;
using System;
using System.IO;

namespace NETInterfacesExercise_DAL
{
    public static class FileOperations
    {
        /// <summary>
        /// Adds a product entry to the "products.txt" file.
        /// </summary>
        /// <param name="product">The product to be added.</param>
        public static void AddProduct(Product product)
        {
            using (StreamWriter writer = new StreamWriter("doc\\products.txt", true)) // Open file in append mode
            {
                writer.WriteLine(product.ToCompactString()); // Write product details in a compact format
            }
        }

        /// <summary>
        /// Logs an exception to the "error_log.txt" file, including timestamp, error type, message, and stack trace.
        /// </summary>
        /// <param name="exception">The exception to be logged.</param>
        public static void LogError(Exception exception)
        {
            using (StreamWriter writer = new StreamWriter("error_log.txt", true)) // Open log file in append mode
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt")); // Log current time
                writer.WriteLine(exception.GetType().Name); // Log exception type
                writer.WriteLine(exception.Message); // Log error message
                writer.WriteLine(exception.StackTrace); // Log stack trace
                writer.WriteLine(new string('-', 80)); // Separator for readability
                writer.WriteLine();
            }
        }
    }

}
