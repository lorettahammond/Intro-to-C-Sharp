using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];

            names[0] = "John Doe";
            names[1] = "Jane Doe";

            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}