using System;
using SareenaCars.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SareenaCars.Models
{
    class Fuel : Models.Timer
    {
        
        protected int fuel
        {
            get { return this.fuel; }
            set { this.fuel = ModelConstants.initialFuel; }
        }
        protected override DateTime Finish
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        protected override DateTime Start
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                while (true)   // The Car is moving
                {
                    fuel -= 1;
                }
            }
        }
    }
}
