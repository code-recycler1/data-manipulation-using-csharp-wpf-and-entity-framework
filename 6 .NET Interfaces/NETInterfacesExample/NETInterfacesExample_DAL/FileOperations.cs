using NETInterfacesExample_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NETInterfacesExample_DAL
{
    /// <summary>
    /// Provides file operations for reading and writing product data.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// Reads product data from a file and returns a list of products.
        /// </summary>
        /// <param name="filePath">The path of the file to read.</param>
        /// <returns>A list of <see cref="Product"/> objects.</returns>
        public static List<Product> ReadFile(string filePath)
        {
            List<Product> productList = new List<Product>();
            List<string> data = null;
            Product product = null;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        data = reader.ReadLine().Split(';').ToList();
                        try
                        {
                            // Determine the type of product and create an instance accordingly.
                            switch (data[0])
                            {
                                case "Boek": // If the product is a book
                                    product = new Book(data[1], data[2], double.Parse(data[3]), data[4]);
                                    break;
                                case "Software": // If the product is software
                                    product = new Software(data[1], data[2], double.Parse(data[3]), data[4]);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            LogError(ex); // Log any parsing errors
                        }

                        productList.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex); // Log any file reading errors
            }

            return productList;
        }

        /// <summary>
        /// Adds a product to the file.
        /// </summary>
        /// <param name="filePath">The path of the file to write to.</param>
        /// <param name="product">The product to add.</param>
        public static void AddProduct(string filePath, Product product)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write($"{product.GetType().Name};{product.Code};{product.Description};{product.Price};");

                // Append additional data specific to the product type.
                if (product is Book book)
                {
                    writer.Write(book.Author);
                }
                else if (product is Software software)
                {
                    writer.Write(software.Version);
                }
                writer.WriteLine();
            }
        }

        /// <summary>
        /// Logs errors to a text file.
        /// </summary>
        /// <param name="error">The exception to log.</param>
        public static void LogError(Exception error)
        {
            using (StreamWriter writer = new StreamWriter("error_log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss tt")); // Log timestamp
                writer.WriteLine(error.GetType().Name); // Log error type
                writer.WriteLine(error.Message); // Log error message
                writer.WriteLine(error.StackTrace); // Log stack trace
                writer.WriteLine(new string('-', 80)); // Separator for readability
                writer.WriteLine();
            }
        }
    }
}
