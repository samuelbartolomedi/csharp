using System;

namespace matrizes05
{
    class matrizes05
    {
        static void Main(string[] args)
        {
            string[] ValoresMatriz = Console.ReadLine().Split(' ');
            int m = int.Parse(ValoresMatriz[0]);
            int n = int.Parse(ValoresMatriz[1]);

            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int[,] c = new int[m, n];

            //leitura matriz a
            for (int i = 0; i < m; i++)
            {
                ValoresMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(ValoresMatriz[j]);
                }
            }

            //leitura matriz b
            for (int i = 0; i < m; i++)
            {
                ValoresMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(ValoresMatriz[j]);
                }
            }

            //gerar matriz c
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            //impressao da matriz c
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
