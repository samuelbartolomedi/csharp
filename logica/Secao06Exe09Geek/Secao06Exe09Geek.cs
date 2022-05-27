using System;

namespace Secao06Exe09Geek
{
    class Secao06Exe09Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o índice de poluição: ");
            double IndicePoluicao = double.Parse(Console.ReadLine());

            if (IndicePoluicao >= 0.3 && IndicePoluicao < 0.4)
            {
                Console.WriteLine("As empresas do grupo 1 devem suspender suas atividades");
            }

            else if (IndicePoluicao >= 0.4 && IndicePoluicao < 0.5)
            {
                Console.WriteLine("As empresas do grupo 1 e 2 devem suspender suas atividades");
            }

            else if (IndicePoluicao >= 0.5)
            {
                Console.WriteLine("Todos os grupos de empresas devem suspender suas atividades");
            }
        }
    }
}
