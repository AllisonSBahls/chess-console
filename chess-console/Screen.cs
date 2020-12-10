using System;
using GameBoard;

namespace chess_console
{
    class Screen
    {
        public static void PrinterBoard(Board board)
        {

            //Um tabuleiro basea em linhas e colunas ou seja uma matriz 8x8
            //Dessa forma irie percorre minhas linhas do tabuleiro
            for (int i = 0; i < board.Lines; i++)
            {
                //E em seguida percorrer as colunas dele
                for (int j = 0; j < board.Columns; j++)
                {
                    //Primeiro é verificado se existe uma peça para imprimir, se não é colocado apenas um traço em branco
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        //Basicamente será feito a impressão de uma peça um espaco em branco

                        Console.Write(board.Piece(i, j) + " ");
                    }

                }
                //Apos preencher todas as linhas da primeira coluna ele quebra a linha
                Console.WriteLine();
            }
        }
    }
}
