namespace SareenaCars.Models.Items.Bonuses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Bonus : Item
    {
        public Bonus(int width, int height) : base(width, height)
        {
        }
    }
}
