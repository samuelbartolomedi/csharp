using System;
using System.Globalization;

namespace DesafioTelefone
{
    internal class DesafioTelefone
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int qtdClientes, contador = 1;

            Console.WriteLine("Informe a quantidade de clientes: ");
            qtdClientes = int.Parse(Console.ReadLine());

            string[] nomes = new string[qtdClientes];
            string[] telefones = new string[qtdClientes];
            int[] tipos = new int[qtdClientes];
            double[] minutos = new double[qtdClientes];
            double[,] precos = new double[3, 2];
            double[] valorConta = new double[qtdClientes];
            double[] minutosExcedentes = new double[qtdClientes];
            double[] valorExcedente = new double[qtdClientes];

            for (int i = 0; i < qtdClientes; i++)
            {
                Console.WriteLine($"Dados do {contador}° cliente:");
                Console.WriteLine("Nome? ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Telefone? ");
                telefones[i] = Console.ReadLine();
                Console.WriteLine("Tipo? ");
                tipos[i] = int.Parse(Console.ReadLine(), CI);
                Console.WriteLine("Minutos? ");
                minutos[i] = double.Parse(Console.ReadLine(), CI);

                
                if (minutos[i] > 90.0)
                {
                    minutosExcedentes[i] = minutos[i] - 90.0;
                }

                contador++;
            }

            Console.WriteLine("Informe o preço básico e excedente de cada tipo de conta: ");

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Tipo {j}? ");
                precos[j, 0] = double.Parse(Console.ReadLine(), CI);
                precos[j, 1] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("RELATÓRIO DE CLIENTES: " +
                "\n");

            for (int n = 0; n < qtdClientes; n++)
            {

                if (tipos[n] == 0 && minutosExcedentes[n] <= 0.0)
                {
                    valorConta[n] = precos[0, 0];
                }

                else if (tipos[n] == 0 && minutosExcedentes[n] > 0.0)
                {
                        valorExcedente[n] = (double)minutosExcedentes[n] * (double)precos[0, 1];
                        valorConta[n] = precos[0, 0] + valorExcedente[n];
                }

                    else if (tipos[n] == 1 && minutosExcedentes[n] <= 0.0)
                    {
                            valorConta[n] = precos[1, 0];
                    }
                        
                        else if (tipos[n] == 1 && minutosExcedentes[n] > 0.0)
                        {
                                valorExcedente[n] = (double)minutosExcedentes[n] * (double)precos[1, 1];
                                valorConta[n] = precos[1, 0] + valorExcedente[n];
                        }

                            else if (tipos[n] == 2 && minutosExcedentes[n] <= 0.0)
                            {
                            valorConta[n] = precos[2, 0];
                            }

                                else if (tipos[n] == 2 && minutosExcedentes[n] > 0.0)
                                { 
                                valorExcedente[n] = (double)minutosExcedentes[n] * (double)precos[2, 1];
                                valorConta[n] = precos[2, 0] + valorExcedente[n];
                                }

                Console.WriteLine($"{nomes[n]}, {telefones[n]}, Tipo {tipos[n]}, Minutos: {minutos[n]}, Conta = R$ {valorConta[n].ToString("F2", CI)}");
            }
        }
    }
}
