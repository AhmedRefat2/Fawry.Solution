using Ecommerce_System.ProductModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.CartModule
{
    internal class Cart
    {
        public List<CartItem> cartItems{ get; private set; } = new List<CartItem>();

        public bool AddItem(Product product, int quantity)
        {
            if (product == null || quantity <= 0 || product.Quantity < quantity)
                return false;

            cartItems.Add(new CartItem(product, quantity));
            return true;
        }

        public bool IsEmpty() => !cartItems.Any();


    }
}
