using Ecommerce_System.CartModule;
using Ecommerce_System.CustomerModule;
using Ecommerce_System.ProductModule;
using Ecommerce_System.ShippingModule;

namespace Ecommerce_System
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
                Hello, this is a my fawry task [Ecommerce] using OOP
                implemented Using : C# => I Can Implemented Using [Java] but not Installed in my pc  
                Organized into Modules : CartModule, CustomerModule, ProductModule, ShippingModule
                handling Exceptions using Custom Exception Classes I made 
                please UnComment 3 Tests One By One HappyTest, BadTest1, BadTest2 to see the results.
                ************** Give Me Your Feedback ahmed202203195@gmail.com **************        
             */



            Test.HappyTest(); // No Exceptions 

            // Test.BadTest1(); // Make Exception [Cart is Empty]

            // Test.BadTest2(); // Make Exception [balance is insufficient.] but I Show it in Console
        }
    }
}
