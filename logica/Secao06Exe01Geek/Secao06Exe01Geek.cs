using System;

namespace Secao06Exe01Geek
{
    class Secao06Exe01Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            double n = double.Parse(Console.ReadLine());

            if(n > 100)
            {
                Console.WriteLine($"Numero informado é maior que 100, numero informado: {n}");
            }

            else
            {
                //vai printar 0 se for menor que 100
                Console.WriteLine($"O numero informado é menor que 100, numero informado: {n = 0}"); 
            }
        }
    }
}
