using System;

namespace Xadrez_Console.tabuleiro.Exceptions
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string Message) : base(Message)
        {
        }
    }
}
