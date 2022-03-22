using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Informe posição de origem: ");
                    Posicao origem = Tela.lerposicaoXadrez().toPosicao();

                    Console.Write("Informe posição de destino: ");
                    Posicao destino = Tela.lerposicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
