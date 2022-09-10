namespace Battleships;

class Board
{
    private boardSize;
    private Cell[,] cells;

    public Board(int boardSize)
    {
        this.boardSize = 10;
        this.cells = new Cell[boardSize, boardSize];
    }

    public bool IsCellEmpty(int x, int y)
    {
        return cells[x, y].cells.IsEmpty;        
    }

    public bool CanShipBePlaced(int x, int y, Ship ship)
    {

        if (x < 0 || y < 0)
            return false;

        if (x >= boardSize || y > boardSize - ship.Length)
            return false;

        for (int i = 0; i < ship.Length; i++)
        {
            if(!IsCellEmpty(x, y+i))
                return false;
        }
        return true;
    }

    private void PlaceShip(int x, int y, Ship ship)
    {
        for (int i = 0; i < ship.Length; i++)
        {
            cells[x,y+i].AssignShip(ship);
        }
    }

    public bool TryToPlaceShip(int x, int y, Ship ship)
    {
        if (!CanShipBePlaced(x, y, ship))
            return false;

        PlaceShip(x, y, ship);
        return true;
    }
}
