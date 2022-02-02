using System;

namespace uri_1046
{
    class uri_1046
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao;

            string[] valores = Console.ReadLine().Split(' ');
            inicio = int.Parse(valores[0]);
            fim = int.Parse(valores[1]);

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
