using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGTraining24
{
    // Polymorphism
    class MyFirstClass
    {
        /*
       // public string s;
        public virtual void polMethod()
        {
            Console.WriteLine("polymorphism example");
        }
        */

        // overloading
        string s1, s2;
        public void polMethod()
        {
            Console.WriteLine("Executing...");
        }
        public void polMethod(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
            Console.WriteLine(s1 + " " + s2);
        }
    }
    /*
    class ExtendedClass : MyFirstClass
    {
        public override void polMethod()
        {
            Console.WriteLine("Reusing the method");
        }
    }
    */
}
