using System;
using System.Threading;

public static class Typewriter
{
    public static void Print(string message, int delay = 20)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
}
