using System;

namespace Secao03Exe05Geek
{
    class Secao03Exe05Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o numero em metros para converter em cm");
            double metros = double.Parse(Console.ReadLine());

            double conversao = metros * 100;
            Console.WriteLine($"metros convertidos em cms: {conversao}");
        }
    }
}
