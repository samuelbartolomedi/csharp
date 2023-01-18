﻿using System;
using System.Collections.Generic;
using ExeAula140.Entities;

namespace ExeAula140
{
    class ExeAula140
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); //instancia nova lista de Employee

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge)); //if checa se é OutsourcedEmployee, se é adiciona na list<Employee> mas estanciando OutSourcedEmployee
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour)); //adiciona na lista Employee após verificar pelo if
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
            }
        }
    }
}