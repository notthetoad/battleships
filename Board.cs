namespace Battleships;

class Board
{
    //private Cell[,] cells = new Cell[BoardSize,BoardSize];
    private Cell[,] cells;

    public Board(int boardSize)
    {
        this.cells = new Cell[boardSize, boardSize];
    }
}
