namespace SareenaCars.Misc
{

    public class Position
    {
        private int xAxis;
        private int yAxis;

        public Position(int xAxis, int yAxis)
        {
            this.XAxis = xAxis;
            this.YAxis = yAxis;
        }    

        public int XAxis
        {
            get { return xAxis; }
            set { xAxis = value; }
        }

        public int YAxis
        {
            get { return yAxis; }
            set { yAxis = value; }
        }

    }
}
