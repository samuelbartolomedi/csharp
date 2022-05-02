using System;

namespace Secao06Exe04Geek
{
    class Secao06Exe04Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura da pessoa");
            double Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo da pessoa (M,m/F,f)");
            char Sexo = char.Parse(Console.ReadLine());

            if (Sexo == 'm' || Sexo == 'M')
            {
                double PesoIdeal = (72.7 * Altura) - 58;
                Console.WriteLine($"Peso ideal para o sexo masculino é: {PesoIdeal.ToString("F2")}");
                
                if (Sexo == 'f' || Sexo == 'F')
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                    Console.WriteLine($"Peso ideal para o sexo feminino é: {PesoIdeal.ToString("F2")}");
                }
            }

            else
            {
<<<<<<< HEAD
                Console.WriteLine("Vc informou um sexo que não está cadastrado, por favor verifique!");
=======
                Console.WriteLine("Vc informou um sexo que não está cadastrado, por favor verifique");
>>>>>>> b328e5e (exercicios geek university)
            }
        }
    }
}