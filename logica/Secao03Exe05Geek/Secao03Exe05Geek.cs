using System;

namespace Secao03Exe05Geek
{
    class Secao03Exe05Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero em metros para converter em cm");
            double metros = double.Parse(Console.ReadLine());

            double conversao = metros * 100;
            Console.WriteLine($"Metros convertidos em cms: {conversao}");
        }
    }
}
