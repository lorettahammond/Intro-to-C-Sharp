using System;
using System.Collections;


namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 8, 0, 5 };
            Array.Sort(numbers);
            foreach (int i in numbers)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
