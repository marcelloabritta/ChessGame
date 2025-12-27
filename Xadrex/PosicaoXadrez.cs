
using System.Runtime.InteropServices;
using TabuleiroModel;

namespace ChessGame.Xadrex
{
    public class PosicaoXadrez(char coluna, int linha)
    {
        public char Coluna { get; set; } = coluna;
        public int Linha { get; set; } = linha;

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

    }
}