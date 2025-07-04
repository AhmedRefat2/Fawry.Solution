using Ecommerce_System.ProductModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ShippingModule
{
    internal static class ShippingService
    {
        private const double shippingRatePer_Kg = 30;

        public static void Ship(List<IShippable> shippingItems)
        {
            if (shippingItems is null || !shippingItems.Any())
            {
                Console.WriteLine("No Items For Shipping!!");
                return;
            }

            double totalWeight = shippingItems.Sum(Item => Item.GetWeight());
            Console.WriteLine("** Shipment notice **");

            foreach (var item in shippingItems)
                Console.WriteLine($"Item: {item.GetName}, Weight: {item.GetWeight() * 1000}g");

            Console.WriteLine($"Total package weight {totalWeight}kg\n");

        }

        public static double CalculateShippingFees(double totalWeight)
            => totalWeight * shippingRatePer_Kg; 
    }
}
