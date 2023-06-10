using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lena Pham
// IT112 
// NOTES: fun for brain
// BEHAVIORS NOT IMPLEMENTED AND WHY: I believe I have everything required

namespace Pham_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                Console.WriteLine("7. Exit");

                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    shipper.Add(new Bicycle());
                }
                else if (input == "2")
                {
                    shipper.Add(new LawnMower());
                }
                else if (input == "3")
                {
                    shipper.Add(new BaseballGlove());
                }
                else if (input == "4")
                {
                    shipper.Add(new Crackers());
                }
                else if (input == "5")
                {
                    shipper.ListItems();
                }
                else if (input == "6")
                {
                    shipper.ComputeShippingCost();
                    exit = true;
                }
                else if (input == "7")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
            }

        }
        
    }
}
