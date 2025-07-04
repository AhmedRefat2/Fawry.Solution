using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.Errors
{
    internal class CartIsEmptyException : Exception
    {
        public CartIsEmptyException() : base("Cart is empty.") { }
    }
}
