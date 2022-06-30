using System;

namespace DesafioConcurso
{
    class DesafioConcurso
    {
        static void Main(string[] args)
        {
            int qtdPessoas = 0;
            double media = 0.0;


            Console.WriteLine("Qual a quantidade de pessoas? ");
            qtdPessoas = int.Parse(Console.ReadLine());

            qtdPessoas += 1;

            string[] nomes = new string[qtdPessoas];
            double[] nota1 = new double[qtdPessoas];
            double[] nota2 = new double[qtdPessoas];

            for (int i = 1; i < qtdPessoas; i++)
            {
                Console.WriteLine($"Digite os dados da {i}° pessoa: ");
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Nota da 1° etapa: ");
                nota1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota da 2° etapa: ");
                nota2[i] = double.Parse(Console.ReadLine());

                
            }

            //Console.WriteLine(nomes[i], nota1[i], nota2[i]);
        }
    }
}
