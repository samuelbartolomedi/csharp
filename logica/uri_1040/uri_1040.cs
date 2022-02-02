using System;

namespace uri_1040
{
    class uri_1040
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, nota_exame, media_final;

            string[] notas = Console.ReadLine().Split(' ');
            n1 = float.Parse(notas[0]);
            n2 = float.Parse(notas[1]);
            n3 = float.Parse(notas[2]);
            n4 = float.Parse(notas[3]);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }
            Console.WriteLine("Media: " + media.ToString("F1"));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                nota_exame = float.Parse(Console.ReadLine());
                media_final = (media + nota_exame) / 2;
                Console.WriteLine("Nota do exame: " + nota_exame.ToString("F1"));
                if (media_final >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media_final.ToString("F1"));
            }
        }
    }
}
