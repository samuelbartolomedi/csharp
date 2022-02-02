using System;

namespace uri_1067
{
    class uri_1067
    {
        static void Main(string[] args)
        {
            int x, i;

            x = int.Parse(Console.ReadLine());

            for (i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
