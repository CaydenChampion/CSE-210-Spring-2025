using System;
using System.Threading;

namespace MindfulnessApp
{
    public class Breathing : Activity
    {
        public Breathing(int duration)
            : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
        { }

        public override void RunActivity()
        {
            DisplayStartingMessage();

            int elapsed = 0;
            while (elapsed < _duration)
            {
                Console.Write("\nBreathe in... ");
                Countdown(3);

                Console.Write("Breathe out... ");
                Countdown(3);

                elapsed += 10;
            }

            DisplayEndingMessage();
        }

        private void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
