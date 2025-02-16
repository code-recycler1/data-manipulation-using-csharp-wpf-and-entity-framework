using MultipleRelationshipsExample_Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MultipleRelationshipsExample_DAL
{
    public class FileOperations
    {
        public static List<Product> ReadFile(string filePath)
        {
            List<Product> products = new List<Product>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    List<string> data = reader.ReadLine().Split(';').ToList();
                    Product product = null;

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
                    catch (Exception)
                    {
                        // Handle potential parsing errors
                    }

                    if (product != null)
                    {
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public static void AddProduct(string filePath, Product product)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write($"{product.GetType().Name};{product.Code};{product.Description};{product.Price};");

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