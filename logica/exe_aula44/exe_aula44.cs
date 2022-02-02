using System;

namespace exe_aula44
{
    class exe_aula44
    {
        static void Main(string[] args)
        {
            int idade, contador;
            double soma, media;

            idade = int.Parse(Console.ReadLine());

            soma = 0.0;
            contador = 0;
            while (idade >= 0)
            {
                soma = soma + idade;
                contador = contador + 1;
                idade = int.Parse(Console.ReadLine());
            }
            if (contador == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / contador;
                Console.WriteLine(media.ToString("F2"));
            }
            Console.ReadLine();
        }
    }
}
