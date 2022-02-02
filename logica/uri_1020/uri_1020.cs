using System;

namespace uri_1020
{
    class uri_1020
    {
        static void Main(string[] args)
        {
            int idade, anos, meses, dias, resto;

            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            resto = idade % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
