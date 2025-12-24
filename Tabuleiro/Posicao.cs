using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tabuleiro
{
    public class Posicao(int linha, int coluna)
    {
        public int Linha { get; set; } = linha;
        public int Coluna { get; set; } = coluna;

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}