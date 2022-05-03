using System;

namespace Secao03Exe04Geek
{
    class Secao03Exe04Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro numero");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            double n2 = double.Parse(Console.ReadLine());

            double soma = n1 + n2;
            Console.WriteLine($"Resultado da soma {soma}");
        }
    }
}
