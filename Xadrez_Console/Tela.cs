using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console
{
    class Tela
    {
        //Metodos da Classe
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            ConsoleColor aux = Console.ForegroundColor;

            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = aux;

                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.MostrarPecaIndividual(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirCorPeca(tab.MostrarPecaIndividual(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  a b c d e f g h") ;
            Console.ForegroundColor = aux;
        }

        public static void ImprimirCorPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
