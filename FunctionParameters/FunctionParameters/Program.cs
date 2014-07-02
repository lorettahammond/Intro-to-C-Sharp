using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 25;                                //defines function
            AddFive(ref number);
            Console.WriteLine(number);
            Console.ReadKey();                              //Console.ReadKey:  helps create interactive console programs. It does not require the user to press enter before returning.
            }
            static void AddFive(ref int number)             //calls function

            {
            number = number + 5;
        }
    }
}
