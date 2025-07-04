using Ecommerce_System.CartModule;
using Ecommerce_System.CustomerModule;
using Ecommerce_System.ProductModule;
using Ecommerce_System.ShippingModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System
{
    internal static class Test
    {
        public static void HappyTest()
        {
            var cheese = new ExpiredAndShippableProduct("Cheese", 100, 5, DateTime.Now.AddDays(5), 0.2);
            var biscuits = new ExpiredAndShippableProduct("Biscuits", 150, 2, DateTime.Now.AddDays(2), 0.7);
            var tv = new ShippableProduct("TV", 300, 3, 5.0);
            var scratchCard = new NonShippableAndNonExpirableProduct("ScratchCard", 50, 10);

            var customer = new Customer("AhmedRefat.Fawry", 1000);
            var cart = new Cart();

            cart.AddItem(cheese, 2);
            cart.AddItem(biscuits, 1);
            cart.AddItem(scratchCard, 1);

            CheckoutService.Checkout(customer, cart);
        }

        public static void BadTest1()
        {
            var cart = new Cart();
            CheckoutService.Checkout(new Customer ("Ahmed", 1000), cart); // Make Exception 
        }

        public static void BadTest2()
        {
            var cheese = new ExpiredAndShippableProduct("Cheese", 100, 5, DateTime.Now.AddDays(5), 0.2);
            var customer = new Customer("AhmedRefat", 0);
            var cart = new Cart();
            cart.AddItem(cheese, 2);
            try
            {
                CheckoutService.Checkout(customer, cart); // Make Exception 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
