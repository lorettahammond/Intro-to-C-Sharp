using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpQuiz071414
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] list = new Person[4];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new Person();
            }

            list[0].name = "Chris Young";
            list[1].name = "Susan Wilson";
            list[2].name = "Kelsey Fox";
            list[3].name = "Larry Friedenberg";

            for (int i = 0; i < list.Length; i++) 
            {
                Console.WriteLine(list[i].name);
            }

            Console.ReadLine();

        }
    }
    // for(int i=0; i<5; i++) 

    class Person 
    {
        public int age { get; set; }            //properties must have { get; set; }
        public string name { get; set; }
        public string department { get; set; }   
        public string login_ID { get; set; }   
        public string clearance_Level { get; set; }   
    }

       
}


 //Hashtable Person = new Hashtable();

        //Person.add("Mark,", "Johnson");
        //Person.add("Susan,", "Wilson");
        //Person.add("Kelsey,", "Fox");
        //Person.add("Larry,", "Friedenberg");

        //Console.WriteLine("first_name, last_name")
        //foreach ()
//phones.Add("John", "123-4567");
//Console.WriteLine("Name\t\tNumber");
//foreach (string name in phones.Keys) 
//{
//    Console.WriteLine(name +"\t"+ phones[name]);
