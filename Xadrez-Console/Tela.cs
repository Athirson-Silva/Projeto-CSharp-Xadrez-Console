using System;
using tabuleiro;

namespace Xadrez_Console
{
    internal class Tela
    {
        public static void imprimirTabuileiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas ; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    Peca peca = tab.peca(i, j);
                    if (peca == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor; //Salva a cor do console
                Console.ForegroundColor = ConsoleColor.Blue; //Altera a cor do console
                Console.Write(peca); //Imprime com a nova cor
                Console.ForegroundColor = aux; //Retorna o console à cor original
            }
        }
    }
}
