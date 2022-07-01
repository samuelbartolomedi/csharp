using System;
using System.Linq;

namespace DesafioConcurso
{
    class DesafioConcurso
    {
        static void Main(string[] args)
        {
            int qtdPessoas = 0;
            double percentagemAprovacao = 0.0;
            var totalParticipantes = 0;
            var totalAprovados = 0;

            Console.WriteLine("Qual a quantidade de pessoas? ");
            qtdPessoas = int.Parse(Console.ReadLine());

            qtdPessoas += 1; //usei o for para o input, então tenho acrescer uma posição nos vetores que estão dinamicos tbm

            string[] nomes = new string[qtdPessoas];
            double[] nota1 = new double[qtdPessoas];
            double[] nota2 = new double[qtdPessoas];
            double[] mediaCandidatos = new double[qtdPessoas];
            //string[] aprovados = new string[j];

            for (int i = 1; i < qtdPessoas; i++)
            {
                Console.WriteLine($"Digite os dados da {i}° pessoa: ");
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Nota da 1° etapa: ");
                nota1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota da 2° etapa: ");
                nota2[i] = double.Parse(Console.ReadLine());

                mediaCandidatos[i] = (nota1[i] + nota2[i]) / 2;
            }

            for (int j = 1; j < qtdPessoas; j++)
            {
                Console.WriteLine("TABELA: \n" +
                   $"{nomes[j]}, {nota1[j]}, {nota2[j]}, MEDIA = {mediaCandidatos[j]}");
            }

            for (int n = 1; n < qtdPessoas; n++) { 
                if (mediaCandidatos[n] > 70.0)
                {

                    Console.WriteLine("PESSOAS APROVADAS: \n" +
                        $"{nomes[n]}\n");

                    totalAprovados = nomes.Count();
                }

            totalParticipantes = nomes.Count();

            percentagemAprovacao = (totalAprovados / totalParticipantes) * 100;
                Console.WriteLine($"Percentagem de aprovação: {percentagemAprovacao.ToString("F2"}");
            
            }

            
        }
    }
}