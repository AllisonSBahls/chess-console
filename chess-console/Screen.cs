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
                /*Inicio de cada linha deve aparecer o numero que vai de 1 a 8
                Mas meu for vai de 0 a 7 da mesma forma que minha matriz
                então p macete é fazer 8 - i. Se i = 1 então sera 8-1 = 7 assim entrando de acordo com a matriz
                 */
                Console.Write(8-i + " ");
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
                        PrinterPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }

                }
                //Apos preencher todas as linhas da primeira coluna ele quebra a linha
                Console.WriteLine();
            }
            //Para as colunas no xadrez basta apenas alinhas manualmente
            Console.WriteLine("  a b c d e f g h");
        }

        //Coloração da peça preto ou branco
        public static void PrinterPiece(Piece piece)
        {
            if(piece.Color == Color.White)
            {
                Console.Write(piece);

            }
            else
            {
                //Tipo do c# que pega a cor do sistema
                ConsoleColor aux = Console.ForegroundColor; //pegar a cor da variavel
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
