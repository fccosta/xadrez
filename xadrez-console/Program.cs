﻿using System;
using tabuleiro;
using xadrez;


namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            /*
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(6, 4));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 5));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 7));
                 
                Tela.imprimirTabuleiro(tab);
                
                Posicao P;

                P = new Posicao(3, 4);

                Console.WriteLine("Posição: " + P);
                
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            */
            Console.ReadLine();

        }
    }
}
