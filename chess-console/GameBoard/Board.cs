

namespace GameBoard
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] piece;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            piece = new Piece[lines, columns];
        }
    }
}
