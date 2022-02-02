using System;

namespace exe_aula67
{
    class exe_aula67
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

            int[] linha = new int[m];

            for (int i = 0; i < m; i++)
            {
                int SomaLinha = 0;
                for (int j = 0; j < n; j++)
                {
                    SomaLinha = SomaLinha + a[i, j];
                }
                linha[i] = SomaLinha;
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(linha[i]);
            }

            Console.ReadLine();

        }
    }
}
