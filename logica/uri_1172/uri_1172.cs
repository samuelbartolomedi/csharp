using System;

namespace uri_1172
{
    class uri_1172
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] <= 0) X[i] = 1;
            }

            for (int i = 0; i < X.Length; i++)
            {
                Console.WriteLine("X[" + i + "] = " + X[i]);
            }
        }
    }
}