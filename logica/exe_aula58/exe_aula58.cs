using System;

namespace exe_aula58
{
    class exe_aula58
    {
        static void Main(string[] args)
        {
            int n;
            double[] a;

            n = int.Parse(Console.ReadLine());
            a = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].ToString("F1") + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + a[i];
            }
            double media = soma / n;

            Console.WriteLine(soma.ToString("F2"));
            Console.WriteLine(media.ToString("F2"));
            Console.ReadLine();
        }
    }
}
