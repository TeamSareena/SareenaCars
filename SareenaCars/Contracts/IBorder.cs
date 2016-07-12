using SareenaCars.Models.Vehicles;
using System.Collections.Generic;

namespace SareenaCars.Contracts
{
    public interface IBorder
    {
        Hero Hero { get; }
        ICollection<IItem> Items {get;}
    }
}
