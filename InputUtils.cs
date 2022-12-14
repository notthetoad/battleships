namespace Battleships;

class InputUtils
{

  public static bool IsValidCharCoord(char c)
  {
    return c >= 'a' && c <= 'z';
  }
  public static void ReadUserInput(out char charCoord, out int intCoord)
  {

    string? input = System.Console.ReadLine();
    charCoord = Char.ToLower(input![0]);
    intCoord = Int32.Parse(input.Substring(1));
    System.Console.WriteLine("{0}, {1}", charCoord, intCoord);
  }

  public static void ParseRawCoord(char rawX, int rawY, out int x, out int y)
  {
    x = rawX - 'a';
    y = rawY - 1;
  }
}
