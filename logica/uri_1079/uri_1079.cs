using System;

namespace uri_1079
{
    class uri_1079
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] notas = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(notas[0]);
                double nota2 = double.Parse(notas[1]);
                double nota3 = double.Parse(notas[2]);

                double media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
