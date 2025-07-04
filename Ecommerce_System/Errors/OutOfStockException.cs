using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.Errors
{
    internal class OutOfStockException : Exception
    {
        public OutOfStockException(string productName)
         : base($"Product '{productName}' is out of stock.")
        {

        }
    }
}
