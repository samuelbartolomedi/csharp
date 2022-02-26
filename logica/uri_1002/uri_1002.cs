using System;

namespace uri_1002
{
    class uri_1002
    {
        static void Main(string[] args)
        {
            double a, r, pi = 3.14159;

            r = double.Parse(Console.ReadLine());

            a = pi * (Math.Pow(r, 2.0));

            Console.WriteLine("A=" + a.ToString("F4"));
        }
    }
}
