﻿using System;

namespace Secao03Exe02
{
    class Secao03Exe02Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a qtd minima em estoque");
            int QtdMin = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a qtd máxima em estoque");
            int QtdMax = int.Parse(Console.ReadLine());

            float EstoqueMedio = (QtdMin + QtdMax) / 2;
            Console.WriteLine($"o estoque médio é {EstoqueMedio.ToString("F2")} unidades");
        }
    }
}
