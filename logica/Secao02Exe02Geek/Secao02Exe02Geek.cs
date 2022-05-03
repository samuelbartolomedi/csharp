using System;

namespace Secao02Exe02Geek
{
    class Secao02Exe02Geek
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor do primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");

            double multiplicacao = soma * num1;
            Console.WriteLine($"O resultado da multiplicacão é: {multiplicacao}");
        }
    }
}
