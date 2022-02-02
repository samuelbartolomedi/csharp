using System;

namespace vetores08
{
    class vetores08
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexos = new char[n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(valores[0]);
                sexos[i] = char.Parse(valores[1]);
            }

            //1: menor altura
            double MenorAltura = alturas[0];
            for (int i = 0; i < n; i++)
            {
                if (alturas[i] < MenorAltura)
                {
                    MenorAltura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + MenorAltura.ToString("F2"));

            //2: maior altura
            double MaiorAltura = alturas[0];
            for (int i = 0; i < n; i++)
            {
                if (alturas[i] > MaiorAltura)
                {
                    MaiorAltura = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + MaiorAltura.ToString("F2"));

            //3: altura media das mulheres
            double SomaAlturaMulheres = 0.0;
            int ContaMulheres = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexos[i] == 'F')
                {
                    SomaAlturaMulheres = SomaAlturaMulheres + alturas[i];
                    ContaMulheres++;
                }
            }

            if (ContaMulheres == 0)
            {
                Console.WriteLine("Não há mulheres dentre as pessoas informadas");
            }
            else
            {
                double MediaAlturaMulheres = SomaAlturaMulheres / ContaMulheres;
                Console.WriteLine("Média das alturas das mulheres = " + MediaAlturaMulheres.ToString("F2"));
            }

            //4: contador de homens
            int ContaHomens = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexos[i] == 'M')
                {
                    ContaHomens++;
                }
            }
            Console.WriteLine("Número de homens = " + ContaHomens);
        }
    }
}
