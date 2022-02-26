using System;

namespace uri_1035
{
    class uri_1035
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            string[] vetor = Console.ReadLine().Split(" ");
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);
            d = int.Parse(vetor[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }
        }
    }
}
