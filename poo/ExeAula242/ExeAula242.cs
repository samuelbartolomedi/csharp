using System;
using System.IO;
using ExeAula242.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

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

            List<Employee> employeeList = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] employeeData = sr.ReadLine().Split(",");
                        string name = employeeData[0];
                        string email = employeeData[1];
                        double salary = double.Parse(employeeData[2], CultureInfo.InvariantCulture);
                        employeeList.Add(new Employee(name, email, salary));
                    }
                    //cria var emails, filtra datasource pelo limite informado, ordena por email e tras na tela os email da restrição
                    var emails = employeeList.Where(obj => obj.Salary > salaryLimit).OrderBy(obj => obj.Email).Select(obj => obj.Email);
                    
                    //cria var sum, filtra os nomes começados em M e faz a soma dos salários desse filtro
                    var sum = employeeList.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                    Console.WriteLine($"Email of people whose salary is more than {salaryLimit.ToString("F2", CultureInfo.InvariantCulture)}: ");
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }


                    Console.WriteLine($"Sum of salary of people whose name starts whit 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
                }

            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
