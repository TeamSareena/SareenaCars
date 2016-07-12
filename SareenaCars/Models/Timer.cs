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
        protected abstract DateTime Finish { get; set; }
        protected abstract DateTime Start { get; set; }

        DateTime ITimer.Finish
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

        DateTime ITimer.Start
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
