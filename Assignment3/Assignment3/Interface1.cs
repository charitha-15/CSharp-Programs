using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    interface Interface1
    {
        void interfaceMethod();
        int interfaceEx();
    }
    interface Interface2
    {
        void interfaceEx2();
    }

    class InterfaceEx : Interface1,Interface2
    {
        int a = 9;
        public void interfaceMethod()
        {
            Console.WriteLine("This is an interface method");
        }
        public int interfaceEx()
        {
            return a;
        }
        public void interfaceEx2()
        {
            Console.WriteLine("Interafce2 method");
        }
    }
}
