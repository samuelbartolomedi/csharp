using System;

namespace exe_aula66
{
    class exe_aula66
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a;
            a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i, i] + " ");
            }

            Console.WriteLine();

            int ContaNegativo = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        ContaNegativo++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + ContaNegativo);
            Console.ReadLine();

        }
    }
}
