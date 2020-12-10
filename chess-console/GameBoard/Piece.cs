using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtdMovements { get; protected set; }
        public Board Board { get; set; }

        public Piece(Position position, Board board, Color color)
        {
            Position = position;
            Board = board;
            Color = color;
            //Inicia em 0 para representar que a peça não se moveu ainda
            this.QtdMovements = 0;        }
    }
    
}
