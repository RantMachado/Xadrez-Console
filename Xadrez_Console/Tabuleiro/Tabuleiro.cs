namespace Xadrez_Console.tabuleiro
{
    class Tabuleiro
    {
        //Auto-Properties
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        //Construtores
        public Tabuleiro()
        {
        }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
