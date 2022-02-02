using System;

namespace uri_1078
{
    class uri_1078
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine(i + " x " + n + " = " + resultado);
            }
        }
    }
}
