using System;

namespace Secao03Exe06Geek
{
    class Secao03Exe06Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor recebido por hora");
            double ValorHr = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o numero de horas trabalhadas no periodo");
            int HrsTrabalhadas = int.Parse(Console.ReadLine());

            double Salario = ValorHr * HrsTrabalhadas;
            Console.WriteLine($"o salario é: {Salario}");
        }
    }
}
