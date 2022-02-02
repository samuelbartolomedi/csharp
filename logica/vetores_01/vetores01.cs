using System;

namespace vetores_01
{
    class vetores01
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i]);
            }

            double maior = vet[0];
            int posicaoMaior = 0;

            for (int i = 1; i < n; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine(maior.ToString("F1"));
            Console.WriteLine(posicaoMaior);

        }
    }
}
