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
        private int currentFuel;

        public Fuel(int currentFuel, DateTime start)
        {
            this.CurrentFuel = currentFuel;
            this.Start = start;
        }

        public  int CurrentFuel
        {
            get { return this.currentFuel; }
            set { this.currentFuel = ModelConstants.initialFuel; }
        }
        protected  DateTime Finish
        {
            get; set;
        }

        protected  DateTime Start
        {
            get; set;
        }
    }
}
