using System;

namespace ExeAula80
{
    class ExeAula80
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n]; //cria matriz

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' '); //cria vetor
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();

            int contadorNegativos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contadorNegativos++;
                    }
                }
            }

            Console.WriteLine("Negative numbers = " + contadorNegativos);
        }
    }
}
