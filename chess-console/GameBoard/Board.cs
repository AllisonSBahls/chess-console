

namespace GameBoard
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        //Como ele é privado não é possivel acessar as peças em outra classes
        private Piece[,] _piece;

        public Board(int Lines, int Columns)
        {
            this.Lines = Lines;
            this.Columns = Columns;
            _piece = new Piece[Lines, Columns];
        }

        //Por ser privado a propiedade peças é feito basicamente um get permitindo acessar a propiedade peças com as linhas e colunas
        public Piece Piece(int lines, int columns)
        {
            return _piece[lines, columns];
        }

        //Criar uma operação para colocar uma peça no tabuleiro
        public void putPiece(Piece p, Position pos)
        {
            //ir na matriz de peças e na posição da linha e coluna coluna para receber a peça
            _piece[pos.Line, pos.Column] = p;
            //e colocar a peça na posição de pos
            p.Position = pos;
        }
    }
}
