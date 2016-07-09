namespace SareenaCars.Misc
{

    public struct Position
    {
 
        public Position(int x, int y)
        {
            this.XAxis = x;
            this.YAxis = y;
        }
        public int XAxis { get; set; }
        public int YAxis { get; set; }
    }
}
