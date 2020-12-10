namespace GameBoard
{
    class Position
    {
       
        public int Row { get; set; }
        public int Column { get; set; }
    
        public Position(int Row, int Column)
        {
            this.Row = Row;
            this.Column = Column;
        }

        public override string ToString()
        {
            return Row + ", " + Column;
        }
    }
}
