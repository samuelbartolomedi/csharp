using System;

namespace ExeAula48
{
    class ExeAula48
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares vc vai comprar?");
            double quantia = double.Parse(Console.ReadLine());

            double resultado = ConversorDeMoeda.ConversaoDolaresReais(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2"));
        }
    }
}
