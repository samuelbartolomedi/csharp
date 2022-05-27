using System;

namespace Secao06Exe10Geek
{
    class Secao06Exe10Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("O nadador está na categoria infantil-a");
            }

            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("O nadador está na categoria infantil-b");
            }

            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("O nadador está na categoria juvenil-a");
            }

            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("O nadador está na categoria juvenil-b");
            }

            else if (idade >= 18)
            {
                Console.WriteLine("O nadador está na categoria adultos");
            }
        }
    }
}
