using System;

namespace uri_1159
{
    class uri_1159
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x = x + 1;
                }
                int soma = 5 * x + 20;
                Console.WriteLine(soma.ToString());

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
