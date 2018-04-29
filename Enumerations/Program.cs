using System;

namespace Enumerations
{
    class Program
    {
        enum Days {Sun,Mon,Tue,Wed,Thu,Fri,Sat};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Enumerations!");
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0}",x);
            Console.WriteLine("Fri = {0}",y);
            Console.WriteLine(Days.Thu);

        }
    }
}
