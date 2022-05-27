using System;

namespace Secao07Exe01Geek
{
    class Secao07Exe01Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor: ");
            double valor = double.Parse(Console.ReadLine());

            double maior = 0;
            while (valor != 0)
            {
                if (valor > maior)
                {
                    maior = valor;
                }

                Console.WriteLine("Informe um valor: ");
                valor = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"O maior valor foi: {maior.ToString("F2")}");
        }
    }
}
