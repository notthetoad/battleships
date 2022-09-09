namespace Battleships
{
    class Field
    {
        private static int x;
        private static int y;
        private static int[] position = new int[2];

        public static int X
        {
            get => x;
            set => x = value;
        }

        public static int Y
        {
            get => y;
            set => y = value;
        }

        public static int[] Position
        {
            get => position;
            set => position = value;
        }
    }
}
