namespace TabuleiroModel
{
    public abstract class Peca(Tabuleiro tabuleiro, Cor cor)
    {
        public Posicao? Posicao { get; set; } = null;
        public Cor Cor { get; protected set; } = cor;
        public int QteMovimentos { get; protected set; } = 0;
        public Tabuleiro Tabuleiro { get; protected set; } = tabuleiro;

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}