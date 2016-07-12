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
        public abstract DateTime Finish { get; set; }
        public abstract DateTime Start { get; set; }
    }
}
