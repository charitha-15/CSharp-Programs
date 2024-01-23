using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGTraining24
{
    class ArraysEx
    {
       public void stringArray()
        {
            String[] arr = { "Hello", "charitha", "19012024", "C#" };
            Console.WriteLine(arr[2]);
            for (int i=0;i<=arr.Length-1;i++)
            {
                Console.WriteLine(arr[i]);
            }
            arr[1] = ".NET";
            Console.WriteLine(arr[1]);
        }

    }
}
