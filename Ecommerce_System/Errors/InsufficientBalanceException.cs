using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.Errors
{
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string customerName)
            : base($"Customer [{customerName}] balance is insufficient.")
        {

        }
    }
}
