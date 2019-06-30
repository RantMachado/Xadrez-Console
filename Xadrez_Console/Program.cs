using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.Xadrez;
using Xadrez_Console.tabuleiro.Enums;
using Xadrez_Console.tabuleiro.Exceptions;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 4));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(7, 4));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 7));


                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
