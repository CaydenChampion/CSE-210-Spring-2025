using System;

class MainClass
{
    static void Main(string[] args)
    {
        Typewriter.Print("Welcome to the Journal Program!\n", 40);
        Menu menu = new Menu();
        menu.Display();
    }
}