using System;

namespace Secao06Exe03Geek
{
    class Secao06Exe03Geek
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe um número:");
            double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                double p = num;
                Console.WriteLine($"Printa P se for par, valor de p: {p}");
            }

            else
            {
                double i = num;
                Console.WriteLine($"Printa I se for impar, valor de i: {i}");
            }

        }
    }
}
