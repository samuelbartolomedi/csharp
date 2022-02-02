using System;

namespace exe_aula51
{
    class exe_aula51
    {
        static void Main(string[] args)
        {
            double c, f;
            char repetir;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine());
                f = (9.0 * c / 5.0) + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1"));
                Console.WriteLine("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
        }
    }
}
