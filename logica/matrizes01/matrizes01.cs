using System;

namespace valoreses01
{
    class valoreses01
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

            Console.WriteLine("NEGATIVOS:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i,j] < 0)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }
        }
    }
}
