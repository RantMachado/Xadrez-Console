namespace Xadrez_Console.tabuleiro
{
    class Posicao
    {
        //Auto-Properties
        public int Linha { get; set; }
        public int Coluna { get; set; }

        //Construtores
        public Posicao()
        {
        }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
