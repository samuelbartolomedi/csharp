using System;

namespace vetores07
{
    class vetores07
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                nota1[i] = double.Parse(valores[1]);
                nota2[i] = double.Parse(valores[2]);
            }
            Console.WriteLine("Alunos aprovados:");
            
            for (int i = 0; i < n; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
