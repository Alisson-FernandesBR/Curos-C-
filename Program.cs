using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);
           
            tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab,Cor.Azul), new Posicao(3, 1));
            tab.colocarPeca(new Rei(tab, Cor.Azul), new Posicao(3, 2));

            Tela.imprimirTabuleiro(tab);

        }
    }
}
