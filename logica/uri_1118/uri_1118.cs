using System;

namespace uri_1118
{
    class uri_1118
    {
        static void Main(string[] args)
        {
            int novo_calculo = 1;

            while (novo_calculo == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }
                double nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }
                double media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2"));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novo_calculo = int.Parse(Console.ReadLine());
                while (novo_calculo != 1 && novo_calculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novo_calculo = int.Parse(Console.ReadLine());
                }


            }

        }
    }
}
