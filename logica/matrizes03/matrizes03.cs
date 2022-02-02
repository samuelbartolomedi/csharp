using System;

namespace matrizes03
{
    class matrizes03
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

            for (int i = 0; i < n; i++)
            {
                int maior = matriz[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (matriz[i,j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }

                Console.WriteLine(maior);
            }
        }
    }
}
