using System;

namespace ExeAula45
{
    class Exe1Aula45
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Informe a largura e altura do retângulo");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + ret.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2"));
            
        }
    }
}
