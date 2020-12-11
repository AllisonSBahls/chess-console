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
            PositionChess pos = new PositionChess('a', 3);

            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosition());

            Console.ReadLine();
        
            }
    }
}
