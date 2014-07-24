using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.WriteLine;
            List<string> words = SplitString(input);
            words = ReverseWords(words);
            String output = CombineWords(words);
            Console.WriteLine(output);
        }=
         List<string> SplitString(string str)
        {
        var ret = new List<string>();
        StringBuilder builder = new StringBuilder();
        
        foreach (char letter in str)
        {
            if (letter == " ")
            {
                ret.Add(builder.ToString());
                builder.Clear();
                continue;
            }
            builder.Append(letter);
        }
        return ret:
        }

        List(string) ReverseWords (List(string) words)
        {
            var ret = new List(string)();
            for (int i = words.count=1);
                i >= 0;
                i --
            {
                ret.Add (words[i]);
            }
            return ret;
        }

        String CombineWords (List(string)words)
        {
            var builder = new StringBuilder();

            foreach (string word in words)
            {
                builder += word;
                builder += " ";
            }
            return builder.ToString();
        }
}



        }
    }

    
 
       