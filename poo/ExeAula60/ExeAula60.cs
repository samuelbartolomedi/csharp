using System;

namespace ExeAula60
{
    class ExeAula60
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char respDepositoInicial = char.Parse(Console.ReadLine());
            if (respDepositoInicial == 's' || respDepositoInicial == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double vlrDepositoIncial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, vlrDepositoIncial);
            }
            
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Insira um valor para depositar: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine("Insira um valor para sacar: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
        }
    }
}
