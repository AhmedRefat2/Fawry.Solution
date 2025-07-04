using Ecommerce_System.CartModule;
using Ecommerce_System.CustomerModule;
using Ecommerce_System.Errors;
using Ecommerce_System.ProductModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ShippingModule
{
    internal static class CheckoutService
    {
        public static void Checkout(Customer customer, Cart cart)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer", "Customer Can not be null");
            if (cart.IsEmpty())
                throw new CartIsEmptyException();

            double subtotal = 0;
            List<CartItem> shippingItems = new List<CartItem>();

            foreach (var item in cart.cartItems)
            {
                if (item.Product.IsExpired())
                    throw new ProductExpiredException(item.Product.Name);

                if (item.Product.Quantity < item.Quantity)
                    throw new OutOfStockException(item.Product.Name);

                item.Product.Quantity -= item.Quantity; // Reduce the product quantity in stock
                subtotal += item.Quantity * item.Product.Price; // Calculate subtotal

                if (item.Product is IShippable)
                    shippingItems.Add(item);
            }

            double totalWeight = shippingItems.Sum(p => p.Product.GetWeight());
            double shippingFees = ShippingService.CalculateShippingFees(totalWeight);
            double total = subtotal + shippingFees;

            if (customer.Balance < total)
                throw new InsufficientBalanceException(customer.Name);

            customer.Balance -= total;

            Console.WriteLine($"Customer Name : {customer.Name}\n"); // For Customer Experience

            if (shippingItems.Any())
                ShippingService.Ship(shippingItems);


            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.cartItems)
                Console.WriteLine($"{item.Quantity}x {item.Product.Name} {item.Product.Price * item.Quantity}");

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal {subtotal}");
            Console.WriteLine($"Shipping {shippingFees}");
            Console.WriteLine($"Amount {total}");
            Console.WriteLine($"Remaining Balance: {customer.Balance}"); // Extra point For Customer Experience  
        }
    }
}
