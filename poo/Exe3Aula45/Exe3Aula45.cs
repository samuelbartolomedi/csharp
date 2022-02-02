using System;

namespace Exe3Aula45
{
    class Exe3Aula45
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno? ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe as 3 notas do aluno");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2"));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }

            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.NotaFaltante().ToString("F2") + " pontos");
            }
        }
    }
}
