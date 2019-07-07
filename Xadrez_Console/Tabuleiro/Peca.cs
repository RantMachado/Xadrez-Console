using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.tabuleiro
{
    abstract class Peca
    {
        //Auto-Properties
        public Posicao Posicao{ get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        //Construtores
        public Peca()
        {
        }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QtdMovimentos++;
        }

        public void DecrementarQteMovimentos()
        {
            QtdMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentoPossiveis();

            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentoPossiveis()[pos.Linha, pos.Coluna];
        }


        public abstract bool[,] MovimentoPossiveis();
    }
}
