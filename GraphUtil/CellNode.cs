using System;

namespace GraphUtil
{
    public class CellNode
    {
        public int X { get; }

        public int Y { get; }

        public CellNode(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"Cell at ({X}:{Y})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is CellNode node))
                return false;
            return node.X == X && node.Y == Y;
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            var result = 1;
            result = prime * result + X;
            result = prime * result + Y;
            return result;
        }
    }
}