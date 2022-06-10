using System;

namespace DevSuperior
{
    class ExeIdades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados da primeira pessoa ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            double idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe os dados da segunda pessoa ");
            Console.WriteLine("Nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            double media = (idade + idade2) / 2;
            Console.WriteLine($"A media das idade de {nome} e {nome2} é {media.ToString("F1")}");

        }
    }
}
