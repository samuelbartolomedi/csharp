using System;

namespace uri_1009
{
    class uri_1009
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salario, vendas, total;

            vendedor = Console.ReadLine();

            salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            total = vendas * 0.15 + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
        }
    }
}
