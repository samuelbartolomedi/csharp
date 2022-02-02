using System;

namespace Exe2Aula45
{
    class Exe2Aula45
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome? ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto? ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto? ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do funcionario: " + func);

            Console.WriteLine();
            Console.Write("Porcentagem para aumento de salário? ");
            double PorcentagemAumento = double.Parse(Console.ReadLine());
            func.AumentarSalario(PorcentagemAumento);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

        }
    }
}
