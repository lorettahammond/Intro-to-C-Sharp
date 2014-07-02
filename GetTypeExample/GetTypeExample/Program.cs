using System;
class TypeClass
{
    static void Main(string[] args)
    {
        //create object of type object and string

        Object cls1 = new Object();
        System.String cls2 = "Test string";

        // Call Get Type to return the type
        Type type1 = cls1.GetType();
        Type type2 = cls2.GetType();

        // Object class output
        Console.WriteLine(type1.BaseType);
        Console.WriteLine(type1.Name);
        Console.WriteLine(type1.FullName);
        Console.WriteLine(type1.Namespace);

        // String output
        Console.WriteLine(type2.BaseType);
        Console.WriteLine(type2.Name);
        Console.WriteLine(type2.FullName);
        Console.WriteLine(type2.Namespace);
    }
}
