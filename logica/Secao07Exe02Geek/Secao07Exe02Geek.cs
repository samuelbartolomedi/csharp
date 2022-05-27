using System;

namespace Secao07Exe02Geek
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 10 == 0)
                {
                    Console.Write($"{i} é Multiplo de 10\n");
                }
            }
        }
    }
}
