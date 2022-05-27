using System;

namespace Secao06Exe08Geek
{
    class Secao06Exe08Geek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                if (num > 0)
                {
                    Console.WriteLine("O número informado é par e positivo");
                }

                else
                {
                    Console.WriteLine("O número informado é par e negativo");
                }
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine("O número informado é impar e positivo");
                }

                else
                {
                    Console.WriteLine("O número informado é  impar e negativo");
                }
            }
        }
    }
}