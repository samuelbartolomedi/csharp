using System;
using System.Globalization;

namespace DesafioAtletas
{
    class DesafioAtletas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de atletas? ");

            int qtdAtletas = int.Parse(Console.ReadLine());

            int qtdHomens = 0;

            int qtdMulheres = 0;

            while (qtdAtletas <= 0)
            {
                Console.WriteLine("O número de atletas não pode ser negativo!");
            }

            int i = 0;

            int cont = 1;

            double maiorAltura = 0;

            string nomeMaisAlto = " ";

            for (i = 1; i <= qtdAtletas; i++)
            {
                Console.WriteLine($"Informe os dados do atleta número {i}");
                cont++;
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Sexo: ");
                char sexo = char.Parse(Console.ReadLine());

                while (sexo != 'M' && sexo != 'm' && sexo != 'F' && sexo != 'f')
                {
                    Console.WriteLine("Sexo invalido, deve ser M,m ou F, f");
                }

                if (sexo == 'M' || sexo == 'm')
                {
                    qtdHomens++;
                }
                else
                {
                    qtdMulheres++;
                }

                Console.WriteLine("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (altura <= 0)
                {
                    Console.WriteLine("Altura invalida, insira um valor positivo");
                    altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                maiorAltura = altura;
                nomeMaisAlto = nome;

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeMaisAlto = nome;
                }
                
                Console.WriteLine("Peso: ");
                double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (peso <= 0)
                {
                    Console.WriteLine("Peso invalido, insira um valor positivo");
                    peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }


            }


        }
    }
}