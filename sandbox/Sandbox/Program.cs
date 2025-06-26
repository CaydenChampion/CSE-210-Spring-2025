

// Spinner

using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(" ");

        int duration = 9;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;
        int count = duration;

        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }

        while (DateTime.Now < endTime)
            {
                Console.Write("+");
                Thread.Sleep(sleepTime);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(sleepTime);
                Console.Write("\b");
            }
    }
}




//Circle Program//

// using System;
// using System.Diagnostics.Tracing;
// using System.IO.Compression;



// class Program
// {
//     static void Main(string[] args)
//     {
//         Circle myCircle = new Circle();
//         myCircle.SetRadius(10);
//         Console.WriteLine($"{myCircle.GetRadius()}");
//         Circle myCircle2 = new Circle();
//         myCircle2.SetRadius(20);
//         Console.WriteLine($"{myCircle2.GetRadius()}");

//         Console.WriteLine($"{myCircle.GetArea()}");
//         Console.WriteLine($"{myCircle2.GetArea()}");

//         Cylinder myCylinder = new Cylinder();
//         myCylinder.SetHeight(10);
//         myCylinder.SetCircle(myCircle);
//         Console.WriteLine($"{myCylinder.GetVolume()}");
        
//     }
// }

// End of Circle program //



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