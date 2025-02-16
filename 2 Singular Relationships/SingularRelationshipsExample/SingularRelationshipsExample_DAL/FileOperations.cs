using SingularRelationshipsExample_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SingularRelationshipsExample_DAL
{
    /// <summary>
    /// Static class for file operations.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// Reads products from a file and returns them as a list.
        /// </summary>
        public static List<Product> ReadFile(string filePath)
        {
            List<Product> productList = new List<Product>();
            List<string> data = null;
            Product product = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    data = reader.ReadLine().Split(';').ToList();
                    try
                    {
                        switch (data[0])
                        {
                            case "Product":
                                product = new Product(data[1], data[2], double.Parse(data[3]));
                                break;
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
                        // Handle parsing errors
                    }
                    productList.Add(product);
                }
            }

            return productList;
        }

        /// <summary>
        /// Adds a new product to the file.
        /// </summary>
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
    }
}