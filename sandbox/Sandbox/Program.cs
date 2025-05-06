using System;
using System.Diagnostics.Tracing;
using System.IO.Compression;

class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine ("Error, radius must > 0");
            return;
        }
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");

        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");
    }
}




// class Program
// {
    // static double AddNumbers (double a, double b)
    // {
    //     return a + b;
    // }

    // static void DisplayGreeting()
    // {
    //     Console.WriteLine("Hey Bob, How are you?");
    // }

    // static void Main(string[] args)
    // {
        // Console.WriteLine("Input your first name: ");
        // // Console.Write if you want to input your name on the same line in the terminal.
        // string firstname = Console.ReadLine();
        // Console.WriteLine($"Your first name is: {firstname}");
        // string lastname = Console.ReadLine();
        // Console.WriteLine($"Your last name is: {lastname}, {firstname} {lastname}.");

        // int x = 10;
        // if (x==10)
        // {
        //     Console.WriteLine ("X is 10");
        // }
        // Console.WriteLine("How are you?");
        // for (int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"Hello Bob {i}");
        // }
        // int x = 0;
        // int y = x++;
        // Console.WriteLine(x);
        // Console.WriteLine(y);
        // y = ++x;

        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(99);
        // myNumbers.Add(25);
        // myNumbers.Add(-132);

        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        // }
        // double total = AddNumbers (123.98, 985.12356)
        // Console.WriteLine(total);
        
        // DisplayGreeting();
        // DisplayGreeting();

        // bool done = false;
        // while (!done)
        // {
        //     done = true;
        // }
        // do
        // {

        // } while (!done);


    // }
// }