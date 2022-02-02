using System;

namespace matrizes02
{
    class matrizes02
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
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + matriz[i, j];
                }

                Console.WriteLine(soma);
            }
        }
    }
}
