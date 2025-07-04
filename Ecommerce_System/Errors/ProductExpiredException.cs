using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.Errors
{
    internal class ProductExpiredException : Exception
    {
        public ProductExpiredException(string productName)
            : base($"Product '{productName}' is expired.")
        {

        }
    }
}
