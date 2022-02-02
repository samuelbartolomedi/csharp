using System;

namespace uri_1010
{
    class uri_1010
    {
        static void Main(string[] args)
        {
            int cod1, qtd1, cod2, qtd2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(" ");
            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(" ");
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2]);

            total = qtd1 * preco1 + qtd2 * preco2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
