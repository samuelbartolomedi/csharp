using System;

namespace uri_1113
{
    class uri_1113
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Decrescente;");
                }
                vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
            }
        }
    }
}
