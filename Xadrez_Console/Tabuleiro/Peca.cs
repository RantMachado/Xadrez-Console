﻿using Xadrez_Console.tabuleiro.Enums;

namespace Xadrez_Console.tabuleiro
{
    class Peca
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

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdMovimentos = 0;
        }
    }
}