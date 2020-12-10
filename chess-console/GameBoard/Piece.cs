namespace GameBoard
{
    //Peças genericas
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtdMovements { get; protected set; }
        public Board Board { get; protected  set; }

        public Piece(Board board, Color color)
        {
            //Quando inicia a peça não tem posição
            Position = null;
            Board = board;
            Color = color;
            //Inicia em 0 para representar que a peça não se moveu ainda
            this.QtdMovements = 0;
        }
    }
    
}
