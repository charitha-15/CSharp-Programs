using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        // Constructors
        public string location;
        public Class1() // without param
        {
            location = "Miracle Heights";
        }

        public Class1(string locName) // with param
        {
            location = locName;
        }
         
        // Basic
        public int a = 10;
        public int b = 20;
        public int myMethod()
        {
            return a + b;
        }

        // Fields and methods
        public int empId = 5896;
        public string empName = "charitha";
        public void EmpDetails()
        {
            Console.WriteLine("Employee details are : " + empId + " " + empName);
        }

        // Property
        private int busNo;
        public int BusNo // way 1
        {
            get { return busNo; }
            set { busNo = value; }
        }
        public string BoardingPoint { get; set; } // way 2

    }
}
