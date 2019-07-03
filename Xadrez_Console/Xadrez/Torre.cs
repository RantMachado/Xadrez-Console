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

        //Metodos da Classe Torre
        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.MostrarPecaIndividual(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentoPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.MostrarPecaIndividual(pos) != null && Tabuleiro.MostrarPecaIndividual(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha -= 1;
            }

            //Abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.MostrarPecaIndividual(pos) != null && Tabuleiro.MostrarPecaIndividual(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha += 1;
            }

            //Direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.MostrarPecaIndividual(pos) != null && Tabuleiro.MostrarPecaIndividual(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna += 1;
            }


            //Esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.MostrarPecaIndividual(pos) != null && Tabuleiro.MostrarPecaIndividual(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna -= 1;
            }

            return mat;
        }
    }
}