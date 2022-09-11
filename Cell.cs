namespace Battleships;

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

    public void AssignShip(Ship ship)
    {
        this.ship = ship; 
    }

    public void FireAt()
    {
        if (wasShot)
            return;
        this.wasShot = true; 

        if (!IsEmpty)
            this.ship.Hit();
    }
}
