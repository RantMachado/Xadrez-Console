using Xadrez_Console.tabuleiro;
using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.Xadrez
{
    class Rei : Peca
    {
        //Construtores
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        //Metodos da Classe Rei
        public override string ToString()
        {
            return "R";
        }
    }
}
