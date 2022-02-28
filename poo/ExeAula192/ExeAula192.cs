using System;
using System.IO;
using ExeAula192.Entities;

namespace ExeAula192
{
    class ExeAula192
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2"));
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
