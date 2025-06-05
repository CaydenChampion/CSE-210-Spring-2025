using System;
using System.Threading;

public class Typewriter
{
    public static void WriteLine(string text, int delay = 30)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
}