using System;

namespace matrizes07
{
    class matrizes07
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] ValoresMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(ValoresMatriz[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());

            // decrementar valor da fila
            fila = fila - 1;

            // salva o ultimo da fila
            int UltimoFila = matriz[fila, n - 1];

            // mover todos da fila da direita para esquerda
            for (int j = n - 1; j > 0; j--)
            {
                matriz[fila, j] = matriz[fila, j - 1];
            }

            // armazenar o último na primeira posição da fila
            matriz[fila, 0] = UltimoFila;

            // imprimir a matriz alterada
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
