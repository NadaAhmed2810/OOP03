using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BaseClass
    {
        public virtual void printMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
    //Update Behavior of Base class in binding [dynamic binding]
    internal class DerivedClass01 :BaseClass
    {
        public override void printMessage()
        {
            Console.WriteLine("Message from DerivedClass01");
        }
    }
    //will be new Behavior in binding [static binding]
    internal class DerivedClass02 : BaseClass
    {
        public new void printMessage()
        {
            Console.WriteLine("Message from DerivedClass02");
        }
    }
}
