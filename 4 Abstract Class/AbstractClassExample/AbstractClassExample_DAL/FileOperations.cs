using AbstractClassExample_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AbstractClassExample_DAL
{
    /// <summary>
    /// Provides file operations for reading and writing product data.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// Reads product data from a specified file and returns a list of products.
        /// </summary>
        /// <param name="filePath">The file path of the product data.</param>
        /// <returns>A list of products read from the file.</returns>
        public static List<Product> ReadFile(string filePath)
        {
            List<Product> products = new List<Product>();
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
                            switch (data[0])
                            {
                                // Error occurs because Product is now an abstract class
                                // case "Product":
                                //     product = new Product(data[1], data[2], double.Parse(data[3]));
                                //     break;
                                case "Book":
                                    product = new Book(data[1], data[2], double.Parse(data[3]), data[4]);
                                    break;
                                case "Software":
                                    product = new Software(data[1], data[2], double.Parse(data[3]), data[4]);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            LogError(ex);
                        }

                        products.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            return products;
        }

        /// <summary>
        /// Appends a new product entry to the product file.
        /// </summary>
        /// <param name="filePath">The file path where the product will be added.</param>
        /// <param name="product">The product object to be added.</param>
        public static void AddProduct(string filePath, Product product)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(product.GetType().Name + ";" + product.Code + ";" + product.Description + ";" + product.Price + ";");

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
        /// Logs error details to an error log file.
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
