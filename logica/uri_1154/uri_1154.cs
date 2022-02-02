using System;

namespace uri_1154
{
    class uri_1154
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int soma = 0;
            int contador = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                contador = contador + 1;
                idade = int.Parse(Console.ReadLine());
            }
            double media = (double)soma / contador;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
