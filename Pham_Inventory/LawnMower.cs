using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_Inventory
{
    public class LawnMower : IShippable
    {
        public decimal ShipCost
        {
            get { return 24m; }
        }

        public string Product
        {
            get { return "Lawn Mower"; }
        }
    }
}
