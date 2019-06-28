using Xadrez_Console.tabuleiro;
using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.Xadrez
{
    class Torre : Peca
    {
        //Construtores
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        //Metodos da Classe Rei
        public override string ToString()
        {
            return "T";
        }
    }
}