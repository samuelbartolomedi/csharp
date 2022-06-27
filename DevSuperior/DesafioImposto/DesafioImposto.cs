using Microsoft.Recognizers.Text;
using System;
using System.Globalization;

namespace DesafioImposto
{
    class DesafioImposto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a renda anual com salário: ");
            double rendaAnualSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a renda anual com prestação de serviço: ");
            double rendaAnualServico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a renda anual com ganho de capital: ");
            double rendaAnualCapital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe os gastos médicos: ");
            double gastosMedicos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe os gastos educacionais: ");
            double gastosEducacionais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double impostoSalario = 0;
            double impostoServico = 0;
            double impostoCapital = 0;
            double brutoImpostos = 0;
            double totalGastos = 0;
            double maxDedutivel = 0;
            double liquidoImpostos = 0;

            if (rendaAnualSalario < 36000)
            {
                impostoSalario = rendaAnualSalario * 0.0;
            }

            if (rendaAnualSalario >= 36000 && rendaAnualSalario <= 60000)
            {
                impostoSalario = rendaAnualSalario * 0.10;
            }

            else
            {
                impostoSalario = rendaAnualSalario * 0.20;
            }

            if (rendaAnualServico > 0.0)
            {
                impostoServico = rendaAnualServico * 0.15;
            }
            else
            {
                impostoServico = rendaAnualServico * 0.0;
            }

            if (rendaAnualCapital > 0.0)
            {
                impostoCapital = rendaAnualCapital * 0.20;
            }
            else
            {
                impostoCapital = rendaAnualCapital * 0.0;
            }

            brutoImpostos = impostoCapital + impostoSalario + impostoServico;

            maxDedutivel = brutoImpostos * 0.30;

            totalGastos = gastosMedicos + gastosEducacionais;

            if (totalGastos > maxDedutivel)
            {
                liquidoImpostos = brutoImpostos - maxDedutivel;

                Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA\n" +
                    "\n" +
                    "CONSOLIDADO DE RENDA:\n" +
                    $"Imposto sobre salario: {impostoSalario.ToString("F2")}\n" +
                    $"Imposto sobre serviços: {impostoServico.ToString("F2")}\n" +
                    $"Imposto sobre ganho de capital: {impostoCapital.ToString("F2")}\n" +
                    "\n" +
                    "DEDUÇÕES:\n" +
                    $"Máximo dedutível: {maxDedutivel.ToString("F2")}\n" +
                    $"Gastos dedutíveis: {totalGastos.ToString("F2")}\n" +
                    "\n" +
                    "RESUMO:\n" +
                    $"Imposto bruto total: {brutoImpostos.ToString("F2")}\n" +
                    $"Abatimento: {maxDedutivel.ToString("F2")}\n" +
                    $"Imposto devido: {liquidoImpostos.ToString("F2")}");
            }
            else
            {
                liquidoImpostos = brutoImpostos - totalGastos;

                Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA\n" +
                    "\n" +
                    "CONSOLIDADO DE RENDA:\n" +
                    $"Imposto sobre salario: {impostoSalario.ToString("F2")}\n" +
                    $"Imposto sobre serviços: {impostoServico.ToString("F2")}\n" +
                    $"Imposto sobre ganho de capital: {impostoCapital.ToString("F2")}\n" +
                    "\n" +
                    "DEDUÇÕES:\n" +
                    $"Máximo dedutível: {maxDedutivel.ToString("F2")}\n" +
                    $"Gastos dedutíveis: {totalGastos.ToString("F2")}\n" +
                    "\n" +
                    "RESUMO:\n" +
                    $"Imposto bruto total: {brutoImpostos.ToString("F2")}\n" +
                    $"Abatimento: {totalGastos.ToString("F2")}\n" +
                    $"Imposto devido: {liquidoImpostos.ToString("F2")}");
            }
        }
    }
}
