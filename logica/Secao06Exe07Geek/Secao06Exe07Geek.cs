using System;

namespace Secao06Exe07Geek
{
    class Secao06Exe07Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 4 números separados por espaço, ex: 1 2 3 4");
            string[] Numeros = Console.ReadLine().Split(' ');
            
            double[] Quadrado = new double[4];

            double[] Valores = new double[4];

            for (int i = 0; i < Valores.Length; i++)
            {
                Valores[i] = double.Parse(Numeros[i]);
                Quadrado[i] = Valores[i] * Valores[i];

                if (Quadrado[2] >= 1000)
                {
                    Console.WriteLine($"Quadrado do {Valores[2]}° número: {Quadrado[2]}");
                }
                
                else
                {
                    Console.WriteLine($"Quadrado do {i}° número: {Quadrado[i]}");
                }
            }
        }
    }
}
