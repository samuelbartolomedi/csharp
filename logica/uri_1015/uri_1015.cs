using System;

namespace uri_1015
{
    class uri_1015
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia;

            string[] valores = Console.ReadLine().Split();
            x1 = double.Parse(valores[0]);
            y1 = double.Parse(valores[1]);

            valores = Console.ReadLine().Split();
            x2 = double.Parse(valores[0]);
            y2 = double.Parse(valores[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
