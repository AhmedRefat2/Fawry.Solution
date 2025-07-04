using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ProductModule
{
    internal class ExpiredAndShippableProduct : ExpirableProduct, IShippable
    {

        public double Weight { get;}

        public ExpiredAndShippableProduct(string name, decimal price, int quantity, DateTime expireDate, double weight) 
            : base(name, price, quantity, expireDate)
        {
            Weight = weight;
        }

        public override bool IsShippable() => true; // I Assumed that Expired Products Are Shippable
        public override double GetWeight() => Weight;
        public string GetName() => Name;
    }
}
