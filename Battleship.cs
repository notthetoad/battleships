namespace Battleships;

class Battleship : Ship
{
  private static string ShipClassName = "Battleship";
  private static int ShipSize = 5;
  public Battleship() : base(ShipSize, ShipClassName) { }

}
