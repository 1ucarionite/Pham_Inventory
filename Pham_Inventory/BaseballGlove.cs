using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_Inventory
{
    public class BaseballGlove : IShippable
    {
        public decimal ShipCost
        {
            get { return 3.23m; }
        }

        public string Product
        {
            get { return "Baseball Glove"; }
        }
    }
}
