namespace Battleships;

class Board
{
    private int boardSize;
    private Cell[,] cells;

    public Board(int boardSize)
    {
        this.boardSize = 10;
        this.cells = new Cell[boardSize, boardSize];
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                cells[i,j] = new Cell();
            }
        }
    }

    public bool IsCellEmpty(int x, int y)
    {
        return cells[x, y].IsEmpty;
    }

    public bool CanShipBePlaced(int x, int y, Ship ship, bool isVertical)
    {

        if (x < 0 || y < 0)
            return false;

        int xUpperBound;
        int yUpperBound;
        if (isVertical) 
        {
            xUpperBound = boardSize - 1;
            yUpperBound = boardSize - ship.Length;
        }
        else
        {
            xUpperBound = boardSize - ship.Length;
            yUpperBound = boardSize - 1;
        }

        if (x > xUpperBound || y > yUpperBound)
            return false;

        for (int i = 0; i < ship.Length; i++)
        {
            int finalX = isVertical ? x : x+i;
            int finalY = isVertical ? y+i : y;
            if(!IsCellEmpty(finalX, finalY))
                return false;
        }
        return true;
    }

    private void PlaceShip(int x, int y, Ship ship, bool isVertical)
    {
        for (int i = 0; i < ship.Length; i++)
        {
            int finalX = isVertical ? x : x+i;
            int finalY = isVertical ? y+i : y;

            cells[finalX,finalY].AssignShip(ship);
        }
    }

    public bool TryToPlaceShip(int x, int y, Ship ship, bool isVertical)
    {
        if (!CanShipBePlaced(x, y, ship, isVertical))
            return false;

        PlaceShip(x, y, ship, isVertical);
        return true;
    }
    
    public void FireAt(int x, int y)
    {
        cells[x,y].FireAt(); 
    }
}
