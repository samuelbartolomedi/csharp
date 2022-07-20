using System;
using DesafioContribuintes.entities;
using System.Globalization;

namespace DesafioContribuintes
{
    public class DesafioContribuintesPOO
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Informe a renda anual com salário: ");
            double rendaAnualSalario = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Informe a renda anual com prestação de serviço: ");
            double rendaAnualServico = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Informe a renda anual com ganho de capital: ");
            double rendaAnualCapital = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Informe os gastos médicos: ");
            double gastosMedicos = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Informe os gastos educacionais: ");
            double gastosEducacionais = double.Parse(Console.ReadLine(), CI);

            Contribuinte contribuinte = new Contribuinte(rendaAnualSalario, rendaAnualServico, rendaAnualCapital, gastosMedicos, gastosEducacionais);

            Console.WriteLine("\n" +
                "RELATÓRIO:\n" +
                $"Imposto sobre salário: {contribuinte.getImpostoSalario().ToString("F2", CI)}\n" +
                $"Imposto sobre serviços: {contribuinte.getImpostoServico().ToString("F2", CI)}\n" +
                $"Imposto sobre ganho de capital: {contribuinte.getImpostoCapital().ToString("F2", CI)}\n" +
                $"Imposto bruto total: {contribuinte.getBrutoImpostos().ToString("F2", CI)}\n" +
                $"Abatimento: {contribuinte.getAbatimento().ToString("F2", CI)}\n" +
                $"Imposto devido: {contribuinte.getLiquidoImpostos().ToString("F2", CI)}");
        }
    }
}
