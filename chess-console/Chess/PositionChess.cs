using GameBoard;
namespace Chess
{
    //Classe para exibição correta das linhas de 1 a 8 e colunas de "A" a "H"
    class PositionChess
    {
        public char Column { get; set; }
        public int Line { get; set; }

        public PositionChess(char column, int line)
        {
            Column = column;
            Line = line;
        }
        //Metodo para fazer a localização das casa do xadrez
        //Por exemplo a posição da matriz [0,0], no xadrez deverá ser a posição A8
        public Position ToPosition()//transformar objeto para a posição
        {
            //é feita a solução 8 - Line para aparecer corretamente na matriz.
            //Por exemplo o usuário quer mover a peça para a posição A3 então seguindo as posição do xadrez a matriz deve ser 5,0
            return new Position(8 - Line, Column - 'a'); //o Column - 'a' é internamente um número inteiro então é feito o codigo da coluna exemplo b - a que seria 1 - 0 que resultara em 1;
        }

        public override string ToString()
        {
            //Forçar a string
            return "" + Column + Line;
        }
    }
}
