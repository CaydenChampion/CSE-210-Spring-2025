using System;

class Program
{
    static void Main(string[] args)
    // {
    //     Console.Write("Input your first name: ");
    //     // Console.Write if you want to input your name on the same line in the terminal.
    //     string firstname = Console.ReadLine();
    //     Console.WriteLine ($"What is your first name? {firstname}");

    //     Console.Write("Input your last name: ");
    //     string lastname = Console.ReadLine();
    //     Console.WriteLine ($"What is your last name? {lastname}");
    //     Console.WriteLine($"Your name is: {lastname}, {firstname} {lastname}.");
    // }
    
    {
        // Console.Write("Input your first name: ");
        // Console.Write if you want to input your name on the same line in the terminal.
        Console.Write ("What is your first name? ");
        string firstname = Console.ReadLine();

        // Console.Write("Input your last name: ");
        Console.Write ("What is your last name? ");
        string lastname = Console.ReadLine();
        
        Console.WriteLine($"Your name is: {lastname}, {firstname} {lastname}.");
    }
}