using System;

namespace Secao03Exe07Geek
{
    class Secao03Exe07Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura do individuo");
            double Altura = double.Parse(Console.ReadLine());

            double PesoIdeal = (72.7 * Altura) - 58;
            Console.WriteLine($"O peso ideal do individuo é: {PesoIdeal}");
        }
    }
}
