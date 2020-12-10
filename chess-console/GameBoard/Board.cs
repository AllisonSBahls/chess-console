using GameBoard.Exceptions;

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

        //sobrecarga da peça para receber a posição
        public Piece Piece(Position pos)
        {
            return _piece[pos.Line, pos.Column];
        }

        

        //Verificar se existe uma peça em uma dada posição
        public bool ExistPiece(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        //Criar uma operação para colocar uma peça no tabuleiro
        public void PutPiece(Piece p, Position pos)
        {
            //Aqui ele verificara se já existe uma na posição e também faz a validação das posições
            
            if (ExistPiece(pos))
            {
                throw new BoardExecption("There is already piece in that position");
            }

            //ir na matriz de peças e na posição da linha e coluna coluna para receber a peça
            _piece[pos.Line, pos.Column] = p;
            //e colocar a peça na posição de pos
            p.Position = pos;
        }

        //testar a posição já que o tabuleiro so pode ir de 00 a 77
        public bool PositionValidate(Position pos)
        {
            //se a linha ou coluna for maior que 0 ou mais que 8 deve retorna false
            if(pos.Line <0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!PositionValidate(pos))
            {
                throw new BoardExecption("Invalid Position");
            }
        }
    }
}
