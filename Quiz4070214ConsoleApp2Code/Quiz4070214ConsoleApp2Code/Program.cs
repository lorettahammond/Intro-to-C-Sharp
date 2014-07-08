using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4070214ConsoleApp2Code
{
    public class Book : IEnumerable
    {
        public string Title {get; set;}
        public int Price {get; set;}
        public int CompareTo(other.Price);

    class Program
    {
        static void Main(string[] args)
        {
            var Book1 = new Book();
            Book1.Price = 5.99;
            var Book2 = new Book();
            var answer = CompareTo(Book1, Book2);
            Book2.Price = 7;

            var answer = Book1.CompareTo(Book2);

            Console.WriteLine(answer);

        }
    }
}
