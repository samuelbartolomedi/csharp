using System;
using System.Collections.Generic;
using ExeAula137.Entities;

namespace ExeAula137
{
    class ExeAula137
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Inform the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name? ");
                string name = Console.ReadLine();
                Console.Write("Anual income? ");
                double income = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Health expenditures? ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                
                else
                {
                    Console.Write("Numbers of employees? ");
                    int numberOfEmployess = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEmployess));
                }
            }

            double sum = 0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine($"{ tp.Name} $ {tp.Tax().ToString("F2")}");
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine($"Total taxes: $ {sum.ToString("F2")}");
        }
    }
}
