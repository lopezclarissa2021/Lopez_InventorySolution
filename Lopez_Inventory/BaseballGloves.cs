using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopez_Inventory
{
    internal class BaseballGloves : IShippable
    {
        public decimal ShipCost => 3.23M;

        public string Product => "Baseball Glove";
    }
}
