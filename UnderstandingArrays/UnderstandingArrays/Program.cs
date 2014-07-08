using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
            //numbers[5} = 42;

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; //create & initialize array in one line of code

            //Console.WriteLine(numbers[1].ToString());   //retrieves the value of position 1 [number1] in the array, which is 8
            //                                            //use ToString method because the item returned is an integer
            //Console.ReadLine();

            /*
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            foreach (string name in names)   //for each name in the array: retrieve the value; store in a new variable called name of type string; then, execute code.
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
             */



            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();

        

        }
    }
}
