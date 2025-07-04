using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ProductModule
{
    internal class NonShippableAndNonExpirableProduct : Product
    {
        public NonShippableAndNonExpirableProduct(string name, double price, int quantity) : base(name, price, quantity)
        {
            
        }

        public override bool IsExpired() => false; // Non-Expirable Product
    }
}
