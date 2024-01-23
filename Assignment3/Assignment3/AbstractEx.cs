using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    abstract class AbstractEx
    {
        public abstract void abstractMethod();
        public void nonAbsMethod()
        {
            Console.WriteLine("This is concrete method");
        }

    }

    class ConcreteClass : AbstractEx
    {
        public override void abstractMethod()
        {
            Console.WriteLine("This is an abstract method");
        }
    }
}
