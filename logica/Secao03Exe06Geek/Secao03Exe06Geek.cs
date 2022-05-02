using System;

namespace Secao03Exe06Geek
{
    class Secao03Exe06Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor recebido por hora");
            double ValorHr = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero de horas trabalhadas no periodo");
            int HrsTrabalhadas = int.Parse(Console.ReadLine());

            double Salario = ValorHr * HrsTrabalhadas;
            Console.WriteLine($"O salario é: {Salario}");
        }
    }
}
