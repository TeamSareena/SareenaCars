namespace SareenaCars.Models.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Item : Models.MovingObject
    {
        public Item(int width, int height) : base(width, height)
        {
        }
    }
}