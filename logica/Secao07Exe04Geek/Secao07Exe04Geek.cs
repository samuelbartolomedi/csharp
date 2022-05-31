using System;

namespace Secao07Exe04Geek
{
    class Secao07Exe04Geek
    {
        static void Main(string[] args)
        {
            int Valor, Maior = -999, Menor = 999, Soma = 0;
            double Media;
                          
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um valor: ");
                Valor = int.Parse(Console.ReadLine());

                if (Valor > 0)
                {
                    if (Valor > Maior)
                    {
                        Maior = Valor;
                    }
                    if (Valor < Menor)
                    {
                        Menor = Valor;
                    }
                    Soma = Soma + Valor;
                }
                else
                {
                    i--;
                }
            }
            Media = Soma / 10;
            Console.WriteLine($"O maior valor é: {Maior}");
            Console.WriteLine($"O menor valor é: {Menor}");
            Console.WriteLine($"A media dos valores é: {Media}");
        }
    }
}
