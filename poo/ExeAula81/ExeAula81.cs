using System;

namespace ExeAula81
{
    class ExeAula81
    {
        static void Main(string[] args)
        {
            string[] linhas = Console.ReadLine().Split(' '); //cria vetor

            int m = int.Parse(linhas[0]);
            int n = int.Parse(linhas[1]);

            int[,] matriz = new int[m, n]; //cria matriz m por n

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }

                        if(j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }

                        if(i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
