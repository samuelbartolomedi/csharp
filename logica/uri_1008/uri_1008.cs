using System;

namespace uri_1008
{
    class uri_1008
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valor_hora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());

            valor_hora = double.Parse(Console.ReadLine());

            salario = horas * valor_hora;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
