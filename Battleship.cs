namespace Battleships;

class Battleship : Ship
{
    private string name = "Battleship";
    public Battleship(int length) : base(length){}

    public override string GetHitMessage()
    {
        return "Battleship hit";
    }
}
