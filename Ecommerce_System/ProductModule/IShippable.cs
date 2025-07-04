using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_System.ProductModule
{
    internal interface IShippable
    {
        string GetName();
        double GetWeight();
    }
}
