using System;

namespace uri_1048
{
    class uri_1048
    {
        static void Main(string[] args)
        {
            double salario, novo_salario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine());

            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }

        }
    }
}
