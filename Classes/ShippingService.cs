using FawryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Classes
{

    public class ShippingService
    {
        public static void Ship(List<IShippable> items)
        {
            double totalWeight = 0;
            Console.WriteLine("** Shipment notice **");

            foreach (var item in items)
            {
                Console.WriteLine(item.GetName());
                Console.WriteLine($"{item.GetWeight() * 1000}g");
                totalWeight += item.GetWeight();
            }

            Console.WriteLine($"Total package weight {totalWeight:0.0}kg");
        }
    }

}
