using System;

namespace uri1018
{
    internal class uri1018
    {
        static void Main(string[] args)
        {
            int N, cedulas, resto;

            N = int.Parse(Console.ReadLine());

            Console.WriteLine(N);

            cedulas = N / 100;
            resto = N % 100;

            Console.WriteLine($"{cedulas} nota(s) de R$ 100,00");

            cedulas = resto / 50;
            resto = resto % 50;

            Console.WriteLine($"{cedulas} nota(s) de R$ 50,00");
            
            cedulas = resto / 20;
            resto = resto % 20;

            Console.WriteLine($"{cedulas} nota(s) de R$ 20,00");

            cedulas = resto / 10;
            resto = resto % 10;

            Console.WriteLine($"{cedulas} nota(s) de R$ 10,00");

            cedulas = resto / 5;
            resto = resto % 5;

            Console.WriteLine($"{cedulas} nota(s) de R$ 5,00");

            cedulas = resto / 2;
            resto = resto % 2;

            Console.WriteLine($"{cedulas} nota(s) de R$ 2,00");

            cedulas = resto / 1; //nem precisaria? pq?
            Console.WriteLine($"{cedulas} nota(s) de R$ 1,00");
        }
    }
}
