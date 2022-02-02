using System;

namespace ExeAula71
{
    class ExeAula71
    {
        static void Main(string[] args)
        {
            Estudante[] vetorEstudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetorEstudantes[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < vetorEstudantes.Length; i++)
            {
                if(vetorEstudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + vetorEstudantes[i]);
                }
            }
        }
    }
}
