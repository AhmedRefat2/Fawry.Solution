using Ecommerce_System.CartModule;
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

        public static void Ship(List<CartItem> shippingItems)
        {
            if (shippingItems is null || !shippingItems.Any())
            {
                Console.WriteLine("No Items For Shipping!!");
                return;
            }

            double totalWeight = shippingItems.Sum(Item => Item.Product.GetWeight());


            Console.WriteLine("** Shipment notice **");

            foreach (var item in shippingItems)
            {
                int weightInGrams = (int)(item.Product.GetWeight() * 1000);
                Console.WriteLine($"{item.Quantity}x {item.Product.Name} {weightInGrams}g");
            }


            //foreach (var item in shippingItems)
            //    Console.WriteLine($"{} {item.GetName}, Weight: {item.GetWeight() * 1000}g");

            Console.WriteLine($"Total package weight {totalWeight}kg\n");

        }

        public static double CalculateShippingFees(double totalWeight)
            => totalWeight * shippingRatePer_Kg; 
    }
}
