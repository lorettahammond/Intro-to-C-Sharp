using System;

static class WordTools
{
    /// <summary>
    /// Receive string of words and return them in the reversed order.
    /// </summary>
    public static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}

class Program
{
    static void Main()
    {
        const string s1 = "I wish I weren't having so much ";
        const string s2 = "Srinivasa Ramanujan was a brilliant mathematician";

        string rev1 = WordTools.ReverseWords(s1);
        Console.WriteLine(rev1);

        string rev2 = WordTools.ReverseWords(s2);
        Console.WriteLine(rev2);
    }
}
