﻿using System;

namespace DesafioBar
{
    class DesafioBar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o sexo do cliente: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe a qtd de cervejas: ");
            int qtdBeras = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a qtd de refrigerantes: ");
            int qtdRefri = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a qtd de espetinho: ");
            int qtdEspetinho = int.Parse(Console.ReadLine());

            double ingresso = 0;
            double couvert = 0;
            double consumo = 0;

            consumo = (qtdBeras * 5.0) + (qtdRefri * 3.0) + (qtdEspetinho * 7.0) + ingresso;

            if (sexo == 'F' || sexo == 'f')
            {
                ingresso = 8.0;
            }
            else
            {
                ingresso = 10.0;
            }

            if (consumo > 30.0)
            {
                couvert = 0.0;
                string desc = couvert + "Isento de couvert";
                
            }
            else
            {
                couvert = 4.0;
            }

            consumo = (qtdBeras * 5.0) + (qtdRefri * 3.0) + (qtdEspetinho * 7.0) + ingresso + couvert;

            Console.WriteLine("RELATÓRIO: " +
                $"\nConsumo = R${consumo.ToString("F2")}" +
                $"\nCouvert = R${desc}" +
                $"\nIngresso = R${ingresso.ToString("F2")}" +
                $"\nValor a pagar = R${consumo.ToString("F2")}");

        }
    }
}