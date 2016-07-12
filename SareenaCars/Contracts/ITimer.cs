using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SareenaCars.Contracts
{
    public interface ITimer
    {
        DateTime Start { get;  set; }

        DateTime Finish { get; set; }
    }
}
