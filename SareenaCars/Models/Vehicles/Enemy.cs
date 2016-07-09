using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SareenaCars
{
    public abstract class Enemy : Models.MovingObject
    {
        public Enemy(int width, int height) : base(width, height)
        {
        }
    }
}