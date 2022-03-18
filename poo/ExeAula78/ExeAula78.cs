using System;
using System.Collections.Generic;

namespace ExeAula78
{
    class ExeAula78
    {
        static void Main(string[] args)
        {
            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employeesList = new List <Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #" + i + " ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employeesList.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Inform the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee e1 = employeesList.Find(x => x.Id == searchId); //expressao lambda
            if(e1 != null)
            {
                Console.Write("Inform the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                e1.IncreaseSalary(percentage);
            }

            else
            {
                Console.WriteLine("Invalid id, please check the info");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach(Employee obj in employeesList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
