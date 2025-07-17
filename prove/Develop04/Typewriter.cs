using System;
using System.Threading;

namespace MindfulnessApp
{
    public static class Typewriter
    {
        public static void Print(string message, int delay = 50)
        {
            foreach (var c in message)
            {
                if (Console.KeyAvailable)
                {
                    Console.Write(message.Substring(message.IndexOf(c)));
                    Console.ReadKey(true);
                    break;
                }
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
