using System;

namespace vetores04
{
    class vetores04
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(valores[i]);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];
            }

            double media = soma / n;
            Console.WriteLine("média = " + media.ToString("F3"));

            Console.WriteLine("numeros abaixo da média = ");

            for (int i = 0; i < n; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1"));
                }
            }
        }
    }
}
