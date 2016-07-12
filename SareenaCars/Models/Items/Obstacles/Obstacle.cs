namespace SareenaCars.Models.Items.Obstacles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Obstacle : Item
    {
        public Obstacle(int width, int height) : base(width, height)
        {
        }
    }
}
