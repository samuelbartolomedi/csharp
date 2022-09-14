using System;

namespace uri1047
{
    internal class uri1047
    {
        static void Main(string[] args)
        {
            string[] horarios = Console.ReadLine().Split(' ');
            int hr_inicio = int.Parse(horarios[0]);
            int min_inicio = int.Parse(horarios[1]);
            int hr_fim = int.Parse(horarios[2]);
            int min_fim = int.Parse(horarios[3]);

            int instante_inicial = hr_inicio * 60 + min_inicio; // transformou em minutos?
            int instante_final = hr_fim * 60 + min_fim;         // transformou em minutos?

            int duracao;

            if (instante_inicial < instante_final)
            {
                duracao = instante_final - instante_inicial;
            }
            else
            {
                duracao = (24 * 60 - instante_inicial) + instante_final;
            }

            int duracao_hr = duracao / 60;  //divide o total de minutos calculado dentro do if (poderia ser uma função)
            int duracao_min = duracao % 60; //divide o total de minutos calculado dentro do if (poderia ser uma função)

            Console.WriteLine("O JOGO DUROU " + duracao_hr + " HORA(S) E " + duracao_min + " MINUTO(S)");
        }
    }
}
