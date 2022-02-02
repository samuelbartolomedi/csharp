using System;

namespace exe_resolv02
{
    class exe_resolv02
    {
        static void Main(string[] args)
        {
            double b, a, area, perimetro, diagonal;

            Console.WriteLine("Informe a base do retângulo");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do retângulo");
            a = double.Parse(Console.ReadLine());

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = (Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0)));

            Console.WriteLine("Área do retângulo: " + area.ToString("F4"));
            Console.WriteLine("Perimetro do retângulo: " + perimetro.ToString("F4"));
            Console.WriteLine("Diagonal do retângulo: " + diagonal.ToString("F4"));
        }
    }
}

