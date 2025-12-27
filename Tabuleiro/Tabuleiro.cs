namespace TabuleiroModel
{
    public class Tabuleiro(int linhas, int colunas)
    {
        public int Linhas { get; set; } = linhas;
        public int Colunas { get; set; } = colunas;
        private Peca[,] Pecas { get; set; } = new Peca[linhas, colunas];

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;    
        }
    }
}