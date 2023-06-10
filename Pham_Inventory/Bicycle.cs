using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_Inventory
{
    internal class Bicycle : IShippable
    {
        public decimal ShipCost
        {
            get { return 9.50m; }
        }

        public string Product
        {
            get { return "Bicycle"; }
        }
    }
}
