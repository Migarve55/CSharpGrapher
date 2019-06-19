namespace AStarVisualizer
{
    public class CellData
    {
        
        public bool Active { get; set; }
        
        public int X { get; set; }
        
        public int Y { get; set; }

        public CellData(int x, int y)
        {
            Active = false;
            X = x;
            Y = y;
        }
        
    }
}