using System;

namespace exe_aula63
{
    class exe_aula63
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;

            string[] TamanhoMatriz = Console.ReadLine().Split(' ');
            m = int.Parse(TamanhoMatriz[0]);
            n = int.Parse(TamanhoMatriz[1]);

            a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] ValoresMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(ValoresMatriz[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();

            }
        }
    }
}
