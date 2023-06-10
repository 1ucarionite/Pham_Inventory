using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_Inventory
{
    public class Crackers : IShippable
    {
        public decimal ShipCost
        {
            get { return 0.57m; }
        }

        public string Product
        {
            get { return "Crackers"; }
        }
    }
}
