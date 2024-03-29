﻿using System;
using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a'); //Coluna - 'a' para converter o char para o número correspondente da posição
        }

        public override string ToString()
        {
            return "" + Coluna + Linha; //As aspas servem para forçar a transformação em string
        }
    }
}
