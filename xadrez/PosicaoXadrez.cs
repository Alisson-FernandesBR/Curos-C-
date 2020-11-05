using tabuleiro;
namespace xadrez
{
    class PosicaoXadrez
    {
        public char linha { get; set; }
        public char coluna { get; set; }

        public PosicaoXadrez(char linha, char coluna)
        {
            this.linha = linha;
            this.coluna = coluna;


        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + linha + coluna;
        }
    }
}
