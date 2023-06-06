using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopez_Inventory
{
    internal class Bicycles : IShippable
    {
        public decimal ShipCost => 9.50M;
        public string Product => "Bicycle";
    }
}
