﻿using System;
using ExeAula128.Entities.Enums;
using ExeAula128.Entities;

namespace ExeAula120
{
    class ExeAula128
    {
        static void Main(string[] args)
        {
            Console.Write("Inform departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Inform worker data: ");
            Console.Write("Name? ");
            string name = Console.ReadLine();
            Console.Write("Level? (Junior/MidLevel/Senior) ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary? ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName); //instancia classe department
            Worker worker = new Worker(name, level, baseSalary, dept); //instancia classe worker com os parametros dos inputs

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data");
                Console.Write("Date? dd/mm/yyyy ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour? ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration? (hours) ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, duration); //instancia classe contract com os parametros do input
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Inform month and year to calculate income (mm/yyyy): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2"));
        }
    }
}
