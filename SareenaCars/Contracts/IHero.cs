using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SareenaCars
{
    public interface IHero
    {
        int Lives { get; set; }

        int Score { get; set; }
    }
}