using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SareenaCars
{
    public class TruckObstacle : Item
    {
        public TruckObstacle(int width, int height) : base(width, height)
        {
        }

        public override void ChangePosition()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}