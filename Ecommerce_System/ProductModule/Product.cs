using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ProductModule
{
    internal abstract class Product
    {
        protected Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; } // I Supposed That productName Can Not Updated 
        public double Price { get; private set; } // I Supposed Price Can Updated So I Will Handle it If you Needed
        public int Quantity { get; set; }


        public abstract bool IsExpired();
        public virtual bool IsShippable() => false;  // I Supposed That Product Is Not Shippable 
        public virtual double GetWeight() => 0.0; // becuase : Product is NotShippable by defualt
    }
}
