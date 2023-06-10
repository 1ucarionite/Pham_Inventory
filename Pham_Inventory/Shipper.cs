using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pham_Inventory
{
    public class Shipper
    {
        private List<IShippable> items;


        public Shipper()
        {
            items = new List<IShippable>();
        }

        public void Add(IShippable item)
        {
            if (items.Count >= 10)
            {
                Console.WriteLine("Shipment is full, cannot add more items.");
                return;
            }
            items.Add(item);
            Console.WriteLine(item.Product + " has been added.");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }

        public void ListItems()
        {
            Console.WriteLine("Shipment Manifest:");

            List<string> productNames = new List<string>();
            List<int> itemCounts = new List<int>();

            foreach (IShippable item in items)
            {
                string productName = item.Product;

                int index = productNames.IndexOf(productName);
                if (index != -1)
                {
                    itemCounts[index]++;
                }
                else
                {
                    productNames.Add(productName);
                    itemCounts.Add(1);
                }
            }
            for (int i = 0; i < productNames.Count; i++)
            {
                string productName = productNames[i];
                int itemCount = itemCounts[i];

                if (productName == "Crackers")
                {
                    string itemLabel = "Crackers";
                    Console.WriteLine(itemCount + " " + itemLabel);
                }
                else
                {
                    string itemLabel;
                    if (itemCount > 1)
                    {
                        itemLabel = itemCount + " " + productName + "s";
                    }
                    else
                    {
                        itemLabel = itemCount + " " + productName;
                    }
                    Console.WriteLine(itemLabel);
                }
            }

            Console.WriteLine();
        }
    
        public void ComputeShippingCost()
        {
            decimal totalCost = 0;

            foreach (IShippable item in items)
            {
                totalCost += item.ShipCost;
            }

            Console.WriteLine("Total shipping cost for this order is " + totalCost.ToString("C"));
            Console.WriteLine("Press any key to terminate the program");
            Console.ReadKey();
        }
    }
}
