using System;

namespace exe_aula36
{
    class exe_aula36
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"));
            Console.ReadLine();
        }
    }
}
