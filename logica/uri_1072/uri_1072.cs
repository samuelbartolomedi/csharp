using System;

namespace uri_1072
{
    class uri_1072
    {
        static void Main(string[] args)
        {
            int n, x;

            n = int.Parse(Console.ReadLine());

            int contador_in = 0;
            int contador_out = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contador_in = contador_in + 1;
                }
                else
                {
                    contador_out = contador_out + 1;
                }
            }
            Console.WriteLine(contador_in + " in");
            Console.WriteLine(contador_out + " out");
        }
    }
}
