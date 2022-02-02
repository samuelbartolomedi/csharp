using System;

namespace vetores03
{
    class vetores03
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(valores[i]);
            }

            valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(valores[i]);
            }

            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(c[i] + " ");
            }
            
            Console.WriteLine();
        }
    }
}
