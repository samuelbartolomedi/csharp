using System;

namespace uri_1014
{
    class uri_1014
    {
        static void Main(string[] args)
        {
            int x;
            double y, media;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            media = (double)x / y;

            Console.WriteLine(media.ToString("F3") + " km/l");
        }
    }
}
