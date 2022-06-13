using System;

namespace DesafioImposto
{
    class DesafioImposto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a renda anual com salário: ");
            double rendaAnualSalario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a renda anual com prestação de serviço: ");
            double rendaAnualServico = double.Parse(Console.ReadLine());
        }
    }
}
