using System;

namespace ProvaLogica1
{
    class ProvaLogica1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o codigo, qtd e valor");

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);
            double preco = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(valores[0]);
            int qtd2 = int.Parse(valores[1]);
            double preco2 = double.Parse(valores[2]);

            double TotalItem1 = qtd * preco;
            double TotalItem2 = qtd2 * preco2;

            double Total = TotalItem1 + TotalItem2;

            Console.WriteLine("TOTAL A PAGAR: R$ " + Total.ToString("F2"));

        }
    }
}
