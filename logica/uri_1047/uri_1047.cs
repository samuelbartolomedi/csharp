using System;

namespace uri_1047
{
    class uri_1047
    {
        static void Main(string[] args)
        {
            string[] horarios = Console.ReadLine().Split(' ');
            int hr_inicio = int.Parse(horarios[0]);
            int min_inicio = int.Parse(horarios[1]);
            int hr_fim = int.Parse(horarios[2]);
            int min_fim = int.Parse(horarios[3]);

            int instante_inicial = hr_inicio * 60 + min_inicio; //transformou de hrs para min
            int instante_final = hr_fim * 60 + min_fim;         //transformou de hrs para min

            int duracao;

            if (instante_inicial < instante_final)
            {
                duracao = instante_final - instante_inicial;
            }
            else
            {
                duracao = (24 * 60 - instante_inicial) + instante_final; //um dia tem 24 hrs, 1 hr tem 60 mins
            }
            int duracao_hr = duracao / 60;
            int duracao_min = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracao_hr + " HORA(S) E " + duracao_min + " MINUTO(S)");
        }
    }
}
