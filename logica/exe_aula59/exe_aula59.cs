using System;

namespace exe_aula59
{
    class exe_aula59
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2]);

            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2"));

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double) cont / n * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F2") + "%");
        }
    }
}
