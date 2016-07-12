namespace SareenaCars.Models.Items.Obstacles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HoleObstacle : Obstacle
    {
        public HoleObstacle(int width, int height) : base(width, height)
        {
        }

        public override void ChangePosition()
        {
            throw new NotImplementedException();
        }

        public override string Draw()
        {
            throw new NotImplementedException();
        }
    }
}