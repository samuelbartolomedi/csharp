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
            Console.WriteLine("Informe a renda anual com ganho de capital: ");
            double rendaAnualCapital = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe os gastos médicos: ");
            double gastosMedicos = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe os gastos educacionais: ");
            double gastosEducacionais = double.Parse(Console.ReadLine());

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
                impostoServico = rendaAnualServico * 0.20;
            }

            if (rendaAnualCapital > 0.0)
            {
                impostoCapital = rendaAnualCapital * 0.20;
            }

            
            brutoImpostos = impostoCapital + impostoSalario + impostoServico;

            totalGastos = gastosMedicos + gastosEducacionais;

            maxDedutivel = brutoImpostos * 0.30;

            liquidoImpostos = brutoImpostos - maxDedutivel;

            

            Console.WriteLine("RELATÓRIO DE IMPOSTO DE RENDA\n" +
                "\n" +
                "CONSOLIDADO DE RENDA:\n" +
                $"Imposto sobre salario: {impostoSalario}\n" +
                $"Imposto sobre serviços: {impostoServico}\n" +
                $"Imposto sobre ganho de capital: {impostoCapital}\n"+
                "\n" +
                "DEDUÇÕES:\n" +
                $"Máximo dedutível: {maxDedutivel}\n" +
                $"Gastos dedutíveis: {totalGastos}\n" +
                "\n" +
                "RESUMO:\n" +
                $"Imposto bruto total: {brutoImpostos}\n" +
                $"Abatimento: {maxDedutivel}\n" +
                $"Imposto devido: {liquidoImpostos}");
        }
    }
}
