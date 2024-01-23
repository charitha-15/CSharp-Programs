using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class CollectionsEx
    {
        public void collectionMethod()
        {
            //way 1
            var listEle = new List<string>();
            listEle.Add("Hello");
            listEle.Add("Day3");
            listEle.Add("12345");

            foreach(var newList in listEle)
            {
                Console.WriteLine(newList);
            }

            //way 2
            var secList = new List<int>() { 1, 2, 3, 4 };
            foreach(var num in secList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
