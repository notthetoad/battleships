using System;

namespace Battleships
{
    class Ship
    {
        private readonly Random random = new Random();
        public int size = 5;
        public int direction;
        public int x;
        public int y;
        //public int[size] hit;
        //public bool sunk;

        public Ship()
        {
            this.direction = GetRandomNumber(2);
            this.x = GetRandomNumber(10);
            this.y = GetRandomNumber(10);
        }

        private int GetRandomNumber(int n)
        {
            return this.random.Next(n);
        }
    }
}
