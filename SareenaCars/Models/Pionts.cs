using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SareenaCars.Models;
using SareenaCars.Constants;
using System.Threading.Tasks;

namespace SareenaCars.Models
{
    class Pionts : Models.Timer
    {

        protected int points = ModelConstants.initialPoints;
        
        

        protected override DateTime Finish
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                while (true) //The Car is moving
                points +=1;
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
                throw new NotImplementedException();
            }
        }
    }
}
