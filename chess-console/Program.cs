using System;
using GameBoard;
using Chess;
using GameBoard.Exceptions;
namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Board board = new Board(8, 8);


            board.PutPiece(new Rook(board, Color.Black), new Position(0, 0));
            board.PutPiece(new Rook(board, Color.White), new Position(1, 3));
            board.PutPiece(new King(board, Color.Black), new Position(2, 4));
            board.PutPiece(new King(board, Color.White), new Position(4, 1));


                Screen.PrinterBoard(board);
            }
            catch(BoardExecption e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        
            }
    }
}
