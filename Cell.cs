namespace Battleships{

public class Cell
{
    private Ship ship;
    private bool wasShot;

    public bool IsEmpty
    {
        get => ship == null;
    }

    public bool WasShot
    {
        get => wasShot;
    }

    public AssignShip(Ship ship)
    {
        this.ship = ship; 
    }
}
}
