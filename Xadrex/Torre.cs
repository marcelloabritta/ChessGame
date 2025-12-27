using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabuleiroModel;

namespace ChessGame.Xadrex
{
    public class Torre(Tabuleiro tabuleiro, Cor cor) : Peca(tabuleiro, cor)
    {
        public override string ToString()
        {
            return "T";
        }
    }
}