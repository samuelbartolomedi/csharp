using System;

namespace exe_aula35
{
    class exe_aula35
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string[] vetor = Console.ReadLine().Split(' ');

            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
            z = int.Parse(vetor[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("o menor número é: " + x);
            }
            else
            {
                if (y < z)
                {
                    Console.WriteLine("o menor número é: " + y);
                }
                else
                {
                    Console.WriteLine("o menor número é: " + z);
                }
            }

        }
    }
}
