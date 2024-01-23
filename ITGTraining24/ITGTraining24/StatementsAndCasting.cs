using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGTraining24
{
    class StatementsAndCasting
    {
        public void castingMethod()
        {
            int num = 9;
            float floatNum = num; // Implicit
            Console.WriteLine("Implicit casting: " + floatNum);

            double doubleNum = 10.66666666666;
            int intNum = (int)doubleNum; // Explicit
            Console.WriteLine("Explicit casting: " + intNum);

            Console.WriteLine(Convert.ToInt32(doubleNum)); // casting method
        }

        public void Statements()
        {
            int num = 20;
            while(num < 10) // Looping statement
            {
                Console.WriteLine("Hello....");
            }
            Console.WriteLine("While loop not executed");
            for(int i=num;i>=0;i--)
            {
                if(i >= 15) // conditional statement
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("hehe..");
                    break; // Jumping ststement
                }
            }
        }
    }
}
