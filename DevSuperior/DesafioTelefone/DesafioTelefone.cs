using System;

namespace DesafioTelefone
{
    internal class DesafioTelefone
    {
        static void Main(string[] args)
        {
            int qtdClientes = 0, contador = 1;

            string[] nomes = new string[qtdClientes];
            string[] telefones = new string[qtdClientes];
            int[] tipos = new int[qtdClientes];
            double[] minutos = new double[qtdClientes];

            Console.WriteLine("Informe a quantidade de clientes: ");
            qtdClientes = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdClientes; i++)
            {
                Console.WriteLine($"Dados do {contador}° cliente:");
                Console.WriteLine("Nome? ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Telefone? ");
                telefones[i] = Console.ReadLine();
                Console.WriteLine("Tipo? ");
                tipos[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Minutos? ");
                minutos[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe o preço básico e excedente de cada tipo de conta: ");

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"Tipo {j}? ");
            }
        }
    }
}
