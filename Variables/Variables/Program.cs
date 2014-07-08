using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;                  //declare x variable
            int y;                  //declare y variable

            x = 7;                  
            y = x + 3;
            Console.WriteLine(y);
            */

            //string myFirstName;
            //myFirstName = "Loretta";

            //string myFirstName = "Loretta";

            //var myFirstName = "Loretta";

           // Console.WriteLine(myFirstName);

            int x = 7;                          //conver 7 to a string to catenate w/variable y; 
                                               
            //string y = "Bob";
            string y = "5";
            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;

            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);

            Console.ReadLine();
        }
    }
}
