using System;
using System.Collections;
namespace StandardCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList();
            myArrList.Add("First Item");
            myArrList.Add("Third Item");
            myArrList.Add("Second Item");

            myArrList.Sort();
            int itemIndex = myArrList.IndexOf("Third Item");

            foreach(object obj in myArrList)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine();
            Console.WriteLine($"Third Item is at index {itemIndex}.");
        }
    }
}
