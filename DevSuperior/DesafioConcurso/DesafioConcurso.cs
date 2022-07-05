using System;
using System.Globalization;

namespace DesafioConcurso
{
    class DesafioConcurso
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int qtdPessoas = 0, totalAprovados = 0, contador = 1;
            double percentagemAprovados = 0.0, maior = 0.0, somaMediaAprovados = 0.0, mediaAprovados = 0.0;
            string nomeMaior = "";

            Console.WriteLine("Qual a quantidade de pessoas? ");
            qtdPessoas = int.Parse(Console.ReadLine());

            string[] nomes = new string[qtdPessoas];
            double[] nota1 = new double[qtdPessoas];
            double[] nota2 = new double[qtdPessoas];
            double[] mediaCandidatos = new double[qtdPessoas];

            for (int i = 0; i < qtdPessoas; i++)
            {
                Console.WriteLine($"Digite os dados da {contador}° pessoa: ");
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Nota da 1° etapa: ");
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                Console.WriteLine("Nota da 2° etapa: ");
                nota2[i] = double.Parse(Console.ReadLine(), CI);

                mediaCandidatos[i] = (nota1[i] + nota2[i]) / 2;
                contador++;
            }

            Console.WriteLine("\n" +
                "TABELA:");
                for (int j = 0; j < qtdPessoas; j++)
                {
                    Console.WriteLine($"{nomes[j]}, {nota1[j].ToString("F1")}, {nota2[j].ToString("F1")}, MEDIA = {mediaCandidatos[j].ToString("F2", CI)}");
                }

            Console.WriteLine("\n" +
                "APROVADOS:");
            for (int n = 0; n < qtdPessoas; n++)
            {
                if (mediaCandidatos[n] >= 70)
                {
                    Console.WriteLine($"{nomes[n]}\n");
                    somaMediaAprovados = somaMediaAprovados + mediaCandidatos[n];
                    totalAprovados++;
                }
            }

            percentagemAprovados = ((double)totalAprovados / (double)qtdPessoas) * 100 ;
            Console.WriteLine($"Percentagem de aprovação: {percentagemAprovados.ToString("F1", CI)} %");

            maior = mediaCandidatos[0];

            for (int l = 0; l < qtdPessoas; l++)
            {
                if (mediaCandidatos[l] >= maior)
                {
                    maior = mediaCandidatos[l];
                    nomeMaior = nomes[l];
                }
            }

            Console.WriteLine($"Maior média: {nomeMaior}");

            if (totalAprovados <= 0)
            {
                Console.WriteLine("Não há candidatos aprovados");
            }
            else
            {
                mediaAprovados = (double)somaMediaAprovados / (double)totalAprovados;
                Console.WriteLine($"Nota média dos aprovados: {mediaAprovados.ToString("F2", CI)}");
            }
            }
        }
    }