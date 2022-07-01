using System;
using System.Globalization;
using System.Linq;

namespace DesafioConcurso
{
    class DesafioConcurso
    {
        static void Main(string[] args)
        {
            int qtdPessoas = 0, totalAprovados = 0;

            Console.WriteLine("Qual a quantidade de pessoas? ");
            qtdPessoas = int.Parse(Console.ReadLine());

            string[] nomes = new string[qtdPessoas];
            double[] nota1 = new double[qtdPessoas];
            double[] nota2 = new double[qtdPessoas];
            double[] mediaCandidatos = new double[qtdPessoas];
            //string[] aprovados = new string[j];

            for (int i = 0; i < qtdPessoas; i++)
            {
                Console.WriteLine($"Digite os dados da {i}° pessoa: ");
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Nota da 1° etapa: ");
                nota1[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota da 2° etapa: ");
                nota2[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                mediaCandidatos[i] = (nota1[i] + nota2[i]) / 2;
            }

            Console.WriteLine("\n" +
                "TABELA:");
                for (int j = 0; j < qtdPessoas; j++)
                {
                    Console.WriteLine($"{nomes[j]}, {nota1[j].ToString("F1")}, {nota2[j].ToString("F1")}, MEDIA = {mediaCandidatos[j].ToString("F2")}");
                }

            Console.WriteLine("\n" +
                "APROVADOS:");

            for (int n = 0; n < qtdPessoas; n++)
            {
                if (mediaCandidatos[n] >= 70)
                {
                    Console.WriteLine(nomes[n]);
                    totalAprovados++;
                }
            }


            int decimalpraPercentagem = 100;
            decimal percentagemAprovados;

            Console.WriteLine(totalAprovados);
            percentagemAprovados = (totalAprovados / qtdPessoas) * decimalpraPercentagem;

            Console.WriteLine($"Percentagem de aprovação: {percentagemAprovados.ToString("F2")}");
          
            }
        }
    }