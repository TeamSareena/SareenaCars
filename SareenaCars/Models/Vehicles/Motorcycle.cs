using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SareenaCars
{
    public class Motorcycle : Enemy
    {
        public Motorcycle(int width, int height) : base(width, height)
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