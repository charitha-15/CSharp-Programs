using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class ExceptionEx
    {
        public void exceptionMethod()
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("I'll execute irrespective of exception");
            }
        }
    }
}
