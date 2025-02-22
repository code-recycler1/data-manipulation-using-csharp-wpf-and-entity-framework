using NETInterfacesExercise_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NETInterfacesExercise_DAL
{
    /// <summary>
    /// Provides methods for reading and writing product data to files, as well as logging errors.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// Reads product data from the specified file and returns a list of <see cref="Product"/> objects.
        /// </summary>
        /// <param name="fileName">The name (or path) of the file to read.</param>
        /// <returns>A list of products read from the file, or <c>null</c> if an error occurs.</returns>
        public static List<Product> ReadFile(string fileName)
        {
            List<Product> productList = new List<Product>();
            List<string> data = null;
            Product product = null;
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        data = reader.ReadLine().Split(';').ToList();
                        if (double.TryParse(data[3], out double price))
                        {
                            switch (data[0])
                            {
                                case "Book":
                                    product = new Book(data[1], data[2], price, data[4]);
                                    break;
                                case "ElectricKettle":
                                    double.TryParse(data[6], out double capacity);
                                    product = new ElectricKettle(data[1], data[2], price, data[4], data[5], capacity);
                                    break;
                                case "Television":
                                    int.TryParse(data[6], out int hertz);
                                    int.TryParse(data[7], out int screenSize);
                                    product = new Television(data[1], data[2], price, data[4], data[5], hertz, screenSize);
                                    break;
                            }
                            if (!productList.Contains(product))
                            {
                                productList.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                return null;
            }
            return productList;
        }

        /// <summary>
        /// Appends a compact string representation of the specified product to the "products.txt" file.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public static void AddProduct(Product product)
        {
            using (StreamWriter writer = new StreamWriter("doc\\products.txt", true))
            {
                writer.WriteLine(product.ToCompactString());
            }
        }

        /// <summary>
        /// Logs error details to the "error_log.txt" file, including a timestamp, error type, message, and stack trace.
        /// </summary>
        /// <param name="error">The exception to log.</param>
        public static void LogError(Exception error)
        {
            using (StreamWriter writer = new StreamWriter("error_log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt")); // Log current time
                writer.WriteLine(error.GetType().Name); // Log error type
                writer.WriteLine(error.Message); // Log error message
                writer.WriteLine(error.StackTrace); // Log stack trace
                writer.WriteLine(new string('-', 80)); // Separator for readability
                writer.WriteLine();
            }
        }
    }
}
