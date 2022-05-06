using System;

namespace Secao06Exe05Geek
{
    class Secao06Exe05Geek
    {
        static void Main(string[] args)
        {
            double Peso;
            double Excesso;
            double Multa;

            Console.WriteLine("Informe o peso dos peixes pescados pelo João");
            Peso = double.Parse(Console.ReadLine());

            if (Peso > 50)
            {
                Excesso = Peso - 50;
                Multa = Excesso * 4.00;
                Console.WriteLine($"O peso é maior que o estabelecido, foram pescados {Peso} kgs");
                Console.WriteLine($"Excesso foi de {Excesso} kgs");
                Console.WriteLine($"Multa a pagar de {Multa} R$");

            }

            else
            {
                Excesso = 0;
                Multa = 0;
                Console.WriteLine($"O peso {Peso} kgs é menor que o estabelecido, João pagará {Multa} R$ de multa pelo excesso de {Excesso} kgs");
            }
        }
    }
}
