namespace SareenaCars.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Vehicles;

    public class Border : IBorder
    {
        public Border(Hero setHero)
        {
            this.Hero = setHero;
            this.Items = new List<IItem>();

        }
        public Hero Hero { get; set; }

        public ICollection<IItem> Items { get; set; }

        public void Print()
        {
            Console.Write(this.Hero.Draw());
        }
    }
}
