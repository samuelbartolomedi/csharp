using System;
using System.Globalization;

namespace DesafioContribuintes
{
    internal class DesafioContribuintes
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite os dados do contribuinte:");
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
            Console.WriteLine("Digite os dados do contribuinte:");

            //calculado por fora pq não consegui chamar a função que tá fora do main
            double brutoImpostos = 0.0;
            brutoImpostos = CalculaImpostoCapital(rendaAnualCapital) + CalculaImpostoSalario(rendaAnualSalario) + CalculaImpostoServico(rendaAnualServico);

            //calculado por fora pq não consegui chamar a função que tá fora do main
            double abatimento = 0.0;
            double porcentagem = brutoImpostos * 0.3;
            if (gastosMedicos + gastosEducacionais <= porcentagem)
            {
                abatimento = gastosEducacionais + gastosMedicos;
            }
            if (gastosMedicos + gastosEducacionais > porcentagem)
            {
                abatimento = porcentagem;
            }

            Console.WriteLine("\n" +
                "RELATÓRIO:\n" +
                $"Imposto sobre salario: {CalculaImpostoSalario(rendaAnualSalario).ToString("F2", CI)}\n" +
                $"Imposto sobre serviços: {CalculaImpostoServico(rendaAnualServico).ToString("F2", CI)}\n" +
                $"Imposto sobre ganho de capital: {CalculaImpostoCapital(rendaAnualCapital).ToString("F2", CI)}\n" +
                $"Imposto bruto total: {brutoImpostos}\n" +
                $"Abatimento: {CalculaAbatimento(gastosMedicos, gastosEducacionais, brutoImpostos)}\n" +
                $"Imposto devido: {CalculaLiquidoImpostos(brutoImpostos, abatimento)}");


        }
        private static double CalculaImpostoSalario(double rendaAnualSalario)
        {
            /*
             * creps explicou que se eu escrever desta forma fica ate mais legivel o code, a pessoa consegue ler se r
            se renda anual menor 36000
            imposto = 0.0
            
            entre 36000 e 60000
            imposto renda * 0.10

            maior que 60000
            imposto renda * 0.20
             */

            double impostoSalario = 0.0;

            if (rendaAnualSalario < 36000.0)
            {
                impostoSalario = 0.0;
            }
            
            if (rendaAnualSalario >= 36000 & rendaAnualSalario <= 60000)
            {
                impostoSalario = rendaAnualSalario * 0.10;
            }
            if (rendaAnualSalario > 60000)
            {
                impostoSalario = rendaAnualSalario * 0.20;
            }

            return impostoSalario;
        }

        private static double CalculaImpostoServico(double rendaAnaualServico)
        {
            double impostoServico = 0.0;
            return impostoServico = rendaAnaualServico * 0.15;
        }

        private static double CalculaImpostoCapital(double rendaAnualCapital)
        {
            double impostoCapital = 0.0;
            return impostoCapital = rendaAnualCapital * 0.20;
        }

        private static double CalculaBrutoImpostos(double impostoSalario, double impostoCapital, double impostoServico)
        {
            double brutoImpostos = 0.0;
            return brutoImpostos = impostoSalario + impostoSalario + impostoCapital;
        }

        private static double CalculaAbatimento (double gastosEducacionais, double gastosMedicos, double brutoImpostos)
        {
            double abatimento = 0.0;
            double porcentagem = brutoImpostos * 0.3;
            if (gastosMedicos + gastosEducacionais <= porcentagem)
            {
                abatimento = gastosEducacionais + gastosMedicos;
            }
            if (gastosMedicos + gastosEducacionais > porcentagem)
            {
                abatimento = porcentagem;
            }
            return abatimento;
        }

        private static double CalculaLiquidoImpostos(double brutoImpostos, double abatimento)
        {
            double liquidoImpostos = 0.0;
            return liquidoImpostos = brutoImpostos - abatimento;
           
        }
    }
}
