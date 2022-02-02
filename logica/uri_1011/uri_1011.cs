using System;

namespace uri_1011
{
    class uri_1011
    {
        static void Main(string[] args)
        {
            double raio, volume;

            raio = double.Parse(Console.ReadLine());

            volume = (4.0 / 3.0) * 3.14159 * (raio * raio * raio);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
        }
    }
}
