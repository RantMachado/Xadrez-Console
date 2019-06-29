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
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
