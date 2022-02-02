using System;

namespace matrizes06
{
    class matrizes06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] ValoresMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = double.Parse(ValoresMatriz[j]);
                }
            }

            int LinhaEscolhida = int.Parse(Console.ReadLine());
            int ColunaEscolhida = int.Parse(Console.ReadLine());

            // a) soma dos positivos
            double SomaPositivos = 0.0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > 0)
                    {
                        SomaPositivos = SomaPositivos + matriz[i, j];
                    }
                }
            }

            Console.WriteLine("SOMA DOS POSITIVOS: " + SomaPositivos.ToString("F1"));

            // b) imprimir os elementos da linha escolhida
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[LinhaEscolhida, j].ToString("F1") + " ");
            }

            Console.WriteLine();

            // c) imprimir os elementos da coluna escolhida
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, ColunaEscolhida].ToString("F1") + " ");
            }

            Console.WriteLine();

            // d) imprimir a diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i].ToString("F1") + " ");
            }

            Console.WriteLine();

            // e) alterar a matriz elevando os negativos ao quadrado
            for (int i =0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i, j] < 0.0)
                    {
                        matriz[i, j] = Math.Pow(matriz[i, j], 2.0); 
                    }
                }
            }

            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j].ToString("F1") + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
