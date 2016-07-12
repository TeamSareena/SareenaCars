using SareenaCars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SareenaCars.Models
{
    public abstract class Timer : ITimer
    {
        public Timer()
        {

        }


        public DateTime Finish
        {
            get; set;
        }

        public DateTime Start
        {
            get; set;
        }
    }
}
