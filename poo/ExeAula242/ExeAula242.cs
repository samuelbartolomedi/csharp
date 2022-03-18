using System;
using System.IO;
using ExeAula242.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExeAula242
{
    class ExeAula242
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Salary limit? ");
            double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] 
                    }
                }
            }

        }
    }
}
