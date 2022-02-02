using System;

namespace vetores02
{
    class vetores02
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();

            int QtdPares = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    QtdPares++;
                }
            }
            Console.WriteLine(QtdPares);
        }
    }
}
