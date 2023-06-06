using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopez_Inventory
{
    internal class LawnMowers : IShippable
    {
        public decimal ShipCost => 24M;
        public string Product => "Lawn Mower";
    }
}
