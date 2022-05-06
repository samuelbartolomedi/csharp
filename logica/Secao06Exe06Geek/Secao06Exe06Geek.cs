using System;

namespace Secao06Exe06Geek
{
    class Secao06Exe06Geek
    {
        static void Main(string[] args)
        {
            double Codigo, HrsTrabalhadas, Excesso, Salario, HrsExtra, SalarioTotal;
            
            Console.WriteLine("Informe o código do trabalhador");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantia de horas trabalhadas");
            HrsTrabalhadas = double.Parse(Console.ReadLine());
            
            if (HrsTrabalhadas > 50)
            {
                Excesso = HrsTrabalhadas - 50;
                HrsTrabalhadas = HrsTrabalhadas - Excesso;
                Salario = HrsTrabalhadas * 10.0;
                HrsExtra = Excesso * 20.0;
                SalarioTotal = Salario + HrsExtra;

                Console.WriteLine($"Valor total do salário: {SalarioTotal}");
                Console.WriteLine($"Valor do salário base: {Salario}");
                Console.WriteLine($"Valor das horas extra: {HrsExtra}");
            }

            else
            {
                Salario = HrsTrabalhadas * 10.0;
                Console.WriteLine($"Valor total do salário: {Salario}");
            }

        }
    }
}
