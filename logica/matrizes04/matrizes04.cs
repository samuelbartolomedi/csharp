using System;

namespace matrizes04
{
    class matrizes04
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] ValoresMatriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(ValoresMatriz[j]);
                }
            }

            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + matriz[i, i];    
            }

            Console.WriteLine(soma);
        }
    }
}
