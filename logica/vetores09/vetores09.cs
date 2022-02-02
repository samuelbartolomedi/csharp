using System;

namespace vetores09
{
    class vetores09
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] produtos = new string[n];
            double[] VlrCompra = new double[n];
            double[] VlrVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] movimentacoes = Console.ReadLine().Split(' ');
                produtos[i] = movimentacoes[0];
                VlrCompra[i] = double.Parse(movimentacoes[1]);
                VlrVenda[i] = double.Parse(movimentacoes[2]);

            }

                int ContadorAbaixo10 = 0;
                int ContadorEntre1020 = 0;
                int ContadorAcima20 = 0;

            for (int i = 0; i < n; i++)
            {
                double lucro = VlrVenda[i] - VlrCompra[i];

                double PercentagemLucro = lucro / VlrCompra[i] * 100.0;

                if (PercentagemLucro < 10.0)
                {
                    ContadorAbaixo10++;
                }
                else if (PercentagemLucro <= 20.0)
                {
                    ContadorEntre1020++;
                }
                else
                {
                    ContadorAcima20++;
                }
            }
                
                Console.WriteLine("Lucro abaixo de 10%: " + ContadorAbaixo10);
                Console.WriteLine("Lucro entre 10% e 20%: " + ContadorEntre1020);
                Console.WriteLine("Lucro acima de 20%: " + ContadorAcima20);

                double TotalCompra = 0.0;
                double TotalVenda = 0.0;
                
                for (int i = 0; i < n; i++)
            {
                TotalCompra = TotalCompra + VlrCompra[i];
                TotalVenda = TotalVenda + VlrVenda[i];
            }

            double TotalLucro = TotalVenda - TotalCompra;

            Console.WriteLine("Valor total de compra: " + TotalCompra.ToString("F2"));
            Console.WriteLine("Valor total de venda: " + TotalVenda.ToString("F2"));
            Console.WriteLine("Lucro total: " + TotalLucro.ToString("F2"));

                }   
            }        
        }
