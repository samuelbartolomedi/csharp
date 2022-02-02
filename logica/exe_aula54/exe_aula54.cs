using System;

namespace exe_aula54
{
    class exe_aula54
    {
        static void Main(string[] args)
        {
            int n;
            double[] vetor;

            n = int.Parse(Console.ReadLine());
            vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i].ToString("F1"));
            }
            Console.ReadLine();
        }
    }
}
