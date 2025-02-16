using SingularRelationshipsExercises_Models.Exercise_1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SingularRelationshipsExercises_DAL
{
    /// <summary>
    /// A static class that provides file operations.
    /// </summary>
    public static class FileOperations
    {
        /// <summary>
        /// Reads engine data from a file and returns a list of engines.
        /// </summary>
        /// <param name="filePath">The path to the engines file.</param>
        /// <returns>List of Engine objects, or an empty list if an error occurs.</returns>
        public static List<Engine> ReadEnginesFile(string filePath)
        {
            List<Engine> engines = new List<Engine>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var data = reader.ReadLine().Split(';').ToList();
                        if (data.Count >= 2 &&
                            int.TryParse(data[0], out int cylinderCapacity) &&
                            int.TryParse(data[1], out int hp))
                        {
                            Engine engine = new Engine(cylinderCapacity, hp);

                            // Prevent duplicate engines
                            if (!engines.Contains(engine))
                            {
                                engines.Add(engine);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file {filePath}: {ex.Message}");
            }

            return engines;
        }

        /// <summary>
        /// Reads car brand names from a file and returns them as a list of strings.
        /// </summary>
        /// <param name="filePath">The path to the brands file.</param>
        /// <returns>List of brand names, or an empty list if an error occurs.</returns>
        public static List<string> ReadBrandsFile(string filePath)
        {
            List<string> brands = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!brands.Contains(line))  // Avoid duplicates
                        {
                            brands.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading brands file {filePath}: {ex.Message}");
            }

            return brands;
        }

        /// <summary>
        /// Appends a new engine to the specified file.
        /// </summary>
        /// <param name="filePath">The path to the engines file.</param>
        /// <param name="engine">The engine to add.</param>
        public static void AddEngine(string filePath, Engine engine)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{engine.CylinderCapacity};{engine.HP}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file {filePath}: {ex.Message}");
            }
        }
    }
}
