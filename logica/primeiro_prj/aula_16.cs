using System;

namespace primeiro_prj
{
    class aula_16
    {
        static void Main(string[] args)
        {
            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2 * h;

            Console.WriteLine("a área do trapézio é: " + area);

            Console.ReadLine();
        }
    }
}
