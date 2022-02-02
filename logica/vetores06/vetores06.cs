using System;

namespace vetores06
{
    class vetores06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
            }

            int MaiorIdade = idades[0];
            int PosicaoMaiorIdade = 0;

            for (int i = 0; i < n; i++)
            {
                if (idades[i] > MaiorIdade)
                {
                    MaiorIdade = idades[i];
                    PosicaoMaiorIdade = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[PosicaoMaiorIdade]);
        }
    }
}
