using System;

namespace Secao06Exe02Geek
{
    class Secao06Exe02Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                double a = num;
                Console.WriteLine($"O número é positivo {a}");
            }

            else
            {
                double b = num;
                Console.WriteLine($"O número é negativo {b}");
            }
        }
    }
}
