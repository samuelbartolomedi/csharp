using System;
using System.Globalization;

namespace DesafioAtletas
{
    class DesafioAtletas
    {
        static void Main(string[] args)
        {
            int qtdAtletas = 0;
            double altura = 0, maiorAltura = 0, peso = 0, pesoTotal = 0, pesoMedioAtletas = 0, alturaTotalMulheres = 0, alturaMediaMulheres = 0, percentagemHomens = 0, qtdHomens = 0, qtdMulheres = 0;
            //decimal percentagemHomens = 0; (tentativa de corrigir percentagemHomens dando 0, voltei as variaveis pra double e passou oO bug?! why god? why?)
            //decimal qtdHomens = 0, qtdAtletas = 0, qtdMulheres = 0;
            string nome = " ", nomeMaisAlto = " ";
            char sexo = ' ';

            Console.WriteLine("Qual a quantidade de atletas? ");

            qtdAtletas = int.Parse(Console.ReadLine());

            while (qtdAtletas <= 0)
            {
                Console.WriteLine("O número de atletas não pode ser negativo!");
            }

            int i = 0;

            int cont = 1;

            for (i = 1; i <= qtdAtletas; i++)
            {
                Console.WriteLine($"Informe os dados do atleta número {i}");
                cont++;
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Sexo: ");
                sexo = char.Parse(Console.ReadLine());

                while (sexo != 'm' && sexo != 'f')
                {
                    Console.WriteLine("Sexo invalido, deve ser m ou f");
                    sexo = char.Parse(Console.ReadLine());
                }

                if (sexo == 'm')
                {

                    qtdHomens ++;
                }
                else
                {
                    qtdMulheres ++;
                }

                Console.WriteLine("Altura: ");
                altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (altura <= 0)
                {
                    Console.WriteLine("Altura invalida, insira um valor positivo");
                    altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeMaisAlto = nome;
                }

                Console.WriteLine("Peso: ");
                peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (peso <= 0)
                {
                    Console.WriteLine("Peso invalido, insira um valor positivo");
                    peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                pesoTotal = pesoTotal + peso;

                if (sexo == 'f')
                {
                    alturaTotalMulheres = alturaTotalMulheres + altura;
                }
            }

            pesoMedioAtletas = pesoTotal / qtdAtletas;

            alturaMediaMulheres = alturaTotalMulheres / qtdMulheres;

            percentagemHomens = (qtdHomens / qtdAtletas) * 100.0;

            if(qtdMulheres != 0)
            {
                Console.WriteLine("RELATÓRIO FINAL: \n" +
                $"Peso médio dos atletas: {pesoMedioAtletas.ToString("F2")}\n" +
                $"Atleta mais alto: {nomeMaisAlto}\n" +
                $"Porcentagem de homens: {percentagemHomens.ToString("F2")}\n" +
                $"Altura média das mulheres: {alturaMediaMulheres.ToString("F2")}");
            }

            else
            {
                Console.WriteLine("RELATÓRIO FINAL: \n" +
                $"Peso médio dos atletas: {pesoMedioAtletas.ToString("F2")}\n" +
                $"Atleta mais alto: {nomeMaisAlto}\n" +
                $"Porcentagem de homens: {percentagemHomens.ToString("F2")}\n" +
                $"Não há mulheres cadastradas");
            }
        }
    }
}