using System;
using System.IO;
using ExeAula220.Entities;
using System.Collections.Generic;

namespace ExeAula220
{
    class ExeAula220
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime logInstant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, LogInstant = logInstant });
                    }
                    Console.WriteLine("Total of users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
