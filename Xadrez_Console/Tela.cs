using System;
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.MostrarPecaIndividual(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.MostrarPecaIndividual(i, j) + " \n");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
