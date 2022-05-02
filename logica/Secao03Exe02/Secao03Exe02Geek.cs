using System;

namespace Secao03Exe02
{
    class Secao03Exe02Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qtd minima em estoque?");
            int QtdMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Qtd máxima em estoque?");
            int QtdMax = int.Parse(Console.ReadLine());

            float EstoqueMedio = (QtdMin + QtdMax) / 2;
            Console.WriteLine($"O estoque médio é {EstoqueMedio.ToString("F2")} unidades");
        }
    }
}
