using System;

namespace singleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 4;           
            numbers[1] = 5;
            numbers[2] = 6;
            numbers[3] = 7;
            numbers[4] = 8;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[2]);
            int total = 0;
            for(int i = 0; i<numbers.Length;i++ ){
                total = total + numbers[i];
            }
            Console.WriteLine(total.ToString());
            int forEachTotal = 0;
            foreach(int num in numbers)
            {
                forEachTotal = forEachTotal + num;
            }
            Console.WriteLine(forEachTotal);
        }
    }
}
