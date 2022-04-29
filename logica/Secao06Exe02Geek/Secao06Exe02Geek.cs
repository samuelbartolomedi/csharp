using System;

namespace Secao06Exe02Geek
{
    class Secao06Exe02Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um numero");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                double a = num;
                Console.WriteLine($"o numero é positivo {a}");
            }

            else
            {
                double b = num;
                Console.WriteLine($"o numero é negativo {b}");
            }
        }
    }
}
