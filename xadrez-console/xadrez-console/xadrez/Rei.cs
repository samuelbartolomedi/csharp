using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) //repassa as variaveis tab e cor para a super classe Peca
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
