using System;

namespace vetores05
{
    class vetores05
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

            double SomaPares = 0.0;
            int QtdPares = 0;
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    SomaPares = SomaPares + vet[i];
                    QtdPares++;
                }
            }
            if (QtdPares == 0)
            {
                Console.WriteLine("Não havia pares nos numeros informados");
            }
            else
            {
                double media = SomaPares / QtdPares;
                Console.WriteLine("média = " + media.ToString("F1"));
            }
        }
    }
}
