namespace TabuleiroModel
{
    public class Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
    {
        public Posicao Posicao { get; set; } = posicao;
        public Cor Cor { get; protected set; } = cor;
        public int QteMovimentos { get; protected set; } = 0;
        public Tabuleiro Tabuleiro { get; protected set; } = tabuleiro;
    }
}