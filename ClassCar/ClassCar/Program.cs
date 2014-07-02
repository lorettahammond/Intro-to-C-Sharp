using System;

namespace ConsoleApplication1
{
class Program
{
    static void Main(string[] args)
    {
        Car car;							//declares variable Car

        car = new Car("Red");
        Console.WriteLine(car.Describe());

	        //creates a new instance of car, with “Red” as a parameter

        car = new Car("Green");
        Console.WriteLine(car.Describe());

	        //creates a new instance of car, with “Green” as a parameter

        Console.ReadLine();
    }
}
class Car
{
    private string color;		//declares a variable of color

    public Car(string color)	//constructor: Car objects can only be instantiated with a color.
    {
        this.color = color;
    }

    public string Describe()		//Defines a method of Describe ()

    //Describe() method allows us to get a nice message with the single piece of information that we record about car. It simply returns a string with the information we provide

    {
         return "This car is " + Color;
    }

    public string Color
    {
        get { return color; }                                   //gets the color for output; returns the variable, which is color
        set { color = value; }                                  //sets the color for output; assigns the value of color
    }
    }
}
                        //Result is:   This car is Red.
                        //             This car is Green.
