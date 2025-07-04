using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ProductModule
{
    internal class ShippableProduct : Product, IShippable
    {
        public double Weight { get;}
        public ShippableProduct(string name, double price, int quantity, double weight) 
            : base(name, price, quantity)
        {
            Weight = weight;
        }

        public override bool IsExpired() => false; // I Assumed that Shippble Products Dont Expired 
        public override bool IsShippable() => true; // I Assumed that Shippble Products Are Shippable
        public override double GetWeight() => Weight;

        public string GetName() => Name;
    }
}
