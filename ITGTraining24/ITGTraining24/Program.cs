using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary1;

namespace ITGTraining24
{
    // Inheritance
    class Assignment
    {
        public void status()
        {
            Console.WriteLine("What is task status?");
        }
    }
    class Task : Assignment
    {
        public string taskStatus = "completed";
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Statements
            StatementsAndCasting SacObj = new StatementsAndCasting();
            SacObj.Statements();
            Console.ReadLine();
            /*
            // Type casting
            StatementsAndCasting SacObj = new StatementsAndCasting();
            SacObj.castingMethod();
            Console.ReadLine();
            */

            /*
            // Arrays
            ArraysEx ArraysExObj = new ArraysEx();
            ArraysExObj.stringArray();
            Console.ReadLine();
            */

            /*
            // overloading
            MyFirstClass mfc = new MyFirstClass();
            mfc.polMethod();
            mfc.polMethod("charitha", "sri");
            Console.ReadLine();
            */

            /*
            // polymorphism
            MyFirstClass myFirstClassObj = new MyFirstClass();
            MyFirstClass extendedClassObj = new ExtendedClass();
            myFirstClassObj.polMethod();
            extendedClassObj.polMethod();
            Console.ReadLine();
            */

            /*
            // Inheritance
            Task task = new Task();
            task.status();
            Console.WriteLine(task.taskStatus);
            Console.ReadLine();
            */

            /*
            MyFirstClass mfc = new MyFirstClass();
            mfc.s = "This is my first C# program!";
            Console.WriteLine(mfc.s);
            */

            /*
            // Constructors
            Class1 Class1Obj = new Class1(); // without param
            Console.WriteLine("Result without param: "+Class1Obj.location);
            Class1 Class1Obj2 = new Class1("MHeights"); // with param
            Console.WriteLine("Result with param: "+Class1Obj2.location);
            */

            /*
            Console.WriteLine("The addition result is : "+Class1Obj.myMethod());
            */

            /*
            // Properties
            Class1Obj.EmpDetails();
            //way 1
            Class1Obj.BusNo = 5;
            Console.WriteLine("Bus Number is: "+Class1Obj.BusNo);
            //way 2
            Class1Obj.BoardingPoint = "Venkojipalem";
            Console.WriteLine("Boarding point is: " + Class1Obj.BoardingPoint);
            Console.ReadLine();
            */

        }
    }
}
