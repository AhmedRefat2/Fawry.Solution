using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ProductModule
{
    internal class ExpirableProduct : Product
    {
        public DateTime ExpireDate { get; } // Once Set 

        public ExpirableProduct(string name, double price, int quantity, DateTime expireDate)
            : base(name, price, quantity)
        {
            ExpireDate = expireDate;
        }


        public override bool IsExpired()
            => DateTime.Now >= ExpireDate;
    }
}
