﻿using Xadrez_Console.tabuleiro.Exceptions;

namespace Xadrez_Console.tabuleiro
{
    class Tabuleiro
    {
        //Auto-Properties
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas { get; private set; }

        //Construtores
        public Tabuleiro()
        {
        }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        //Metodos da Classe
        public Peca MostrarPecaIndividual(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca MostrarPecaIndividual(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return MostrarPecaIndividual(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (MostrarPecaIndividual(pos) == null)
            {
                return null;
            }
            else
            {
                Peca aux = MostrarPecaIndividual(pos);
                aux.Posicao = null;
                Pecas[pos.Linha, pos.Coluna] = null;
                return aux;
            }
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
