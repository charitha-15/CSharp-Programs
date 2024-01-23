using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Abstract
            ConcreteClass concreteClassObj = new ConcreteClass();
            concreteClassObj.abstractMethod();
            concreteClassObj.nonAbsMethod();
            Console.ReadLine();
            */

            /*
            // Interface
            InterfaceEx interfaceExObj = new InterfaceEx();
            interfaceExObj.interfaceMethod();
            interfaceExObj.interfaceEx2();
            Console.WriteLine(interfaceExObj.interfaceEx());
            Console.ReadLine();
            */

            /*
            // Exception
            ExceptionEx exceptionExObj = new ExceptionEx();
            exceptionExObj.exceptionMethod();
            Console.ReadLine();
            */

            /*
            // Collections
            CollectionsEx collectionsExObj = new CollectionsEx();
            collectionsExObj.collectionMethod();
            Console.ReadLine();
            */

            // Files
            FilesEx filesExObj = new FilesEx();
            filesExObj.fileMethod();
            Console.ReadLine();
           
        }
    }
}
