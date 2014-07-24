using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNewClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Person                             //Create a class Person with the following properties: FirstName; MiddleInitial:LastName; DateofBirth
        {
            string FirstName { get; set; }
            string MiddleInitial {get; set;}
            string LastName { get; set; }
            DateTime DateofBirth { get; set; }
        }

    }
}
