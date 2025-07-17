using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public abstract void RunActivity();

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Typewriter.Print($"--- {_name} ---\n");
            Typewriter.Print(_description);
            Console.Write("\nGet ready...");
            PauseWithAnimation(3);
        }

        protected void DisplayEndingMessage()
        {
            Typewriter.Print("\nGreat job!");
            Typewriter.Print($"You completed {_duration} seconds of {_name}.");
            PauseWithAnimation(3);
        }

        protected void PauseWithAnimation(int seconds)
        {
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(250);
            }
            Console.WriteLine();
        }
    }
}
