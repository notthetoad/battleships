namespace Battleships;

class Battleship : Ship
{
  private static string ShipClass = "Battleship";
  private static int ShipSize = 5;
  public Battleship() : base(ShipSize, ShipClass) { }

}
