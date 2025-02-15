using StaticsExample_Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace StaticsExample_DAL
{
    public class FileOperations
    {
        public List<double> ReadFile(string file)
        {
            List<double> list = new List<double>();
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    try
                    {
                        list.Add(double.Parse(reader.ReadLine()));
                    }
                    catch (Exception ex)
                    {
                        LogErrors(ex);
                    }
                }
            }
            return list;
        }

        public void LogErrors(Exception error)
        {
            using (StreamWriter writer = new StreamWriter(PersonalSettings.OutputFolder + "error_log.txt", true))
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
