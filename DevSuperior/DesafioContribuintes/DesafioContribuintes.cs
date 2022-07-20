using System;
using System.Globalization;

namespace DesafioContribuintes
{
    internal class DesafioContribuintes
    {
        static void Main(string[] args)
        {

            static double CalculaImpostoSalario(double rendaAnualSalario)
            {
                /*creps explicou que se eu escrever desta forma fica ate mais legivel o code, a pessoa consegue ler sem saber os if
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

            static double CalculaImpostoServico(double rendaAnaualServico)
            {
                double impostoServico = 0.0;
                return impostoServico = rendaAnaualServico * 0.15;
            }

            static double CalculaImpostoCapital(double rendaAnualCapital)
            {
                double impostoCapital = 0.0;
                return impostoCapital = rendaAnualCapital * 0.20;
            }

            static double CalculaImpostoBruto(double rendaAnualSalario, double rendaAnualCapital, double rendaAnualServico)
            {
                double impostoBruto;
                return impostoBruto = CalculaImpostoSalario(rendaAnualSalario) + CalculaImpostoServico(rendaAnualServico) + CalculaImpostoCapital(rendaAnualCapital);
            }

            //estava dando diferente os valores pq não estava na mesma ordem as variaveis entre () do CalculaImpostoLiquido e CalculaAbatimento

            static double CalculaAbatimento(double gastosEducacionais, double gastosMedicos, double rendaAnualSalario, double rendaAnualServico, double rendaAnualCapital)
            {
                double impostoBruto = CalculaImpostoBruto(rendaAnualSalario, rendaAnualCapital, rendaAnualServico);
                double abatimento = 0.0;
                double porcentagem = impostoBruto * 0.3;

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

            static double CalculaImpostoLiquido(double gastosEducacionais, double gastosMedicos, double rendaAnualSalario, double rendaAnualServico, double rendaAnualCapital)
            {
                double impostoLiquido = 0.0;
                double impostoBruto = CalculaImpostoBruto(rendaAnualSalario, rendaAnualCapital, rendaAnualServico);
                double abatimento = CalculaAbatimento(gastosEducacionais, gastosMedicos, rendaAnualSalario, rendaAnualServico, rendaAnualCapital);
                return impostoLiquido = impostoBruto - abatimento;

            }

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

            Console.WriteLine("\n" +
                "RELATÓRIO:\n" +
                $"Imposto sobre salario: {CalculaImpostoSalario(rendaAnualSalario).ToString("F2", CI)}\n" +
                $"Imposto sobre serviços: {CalculaImpostoServico(rendaAnualServico).ToString("F2", CI)}\n" +
                $"Imposto sobre ganho de capital: {CalculaImpostoCapital(rendaAnualCapital).ToString("F2", CI)}\n" +
                $"Imposto bruto total: {CalculaImpostoBruto(rendaAnualSalario, rendaAnualCapital, rendaAnualServico).ToString("F2", CI)}\n" +
                $"Abatimento: {CalculaAbatimento(gastosMedicos, gastosEducacionais, rendaAnualSalario, rendaAnualServico, rendaAnualCapital).ToString("F2", CI)}\n" +
                $"Imposto devido: {CalculaImpostoLiquido(gastosEducacionais, gastosMedicos, rendaAnualSalario, rendaAnualServico, rendaAnualCapital).ToString("F2", CI)}");

        }
    }
}