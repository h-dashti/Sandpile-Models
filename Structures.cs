using System;

namespace SandPile
{
    public struct Location
    {
        public int x, y;
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public struct Direction
    {
        public int up, down, left, right;
        public Direction(int up, int down, int right, int left )
        {
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }
    }
}
