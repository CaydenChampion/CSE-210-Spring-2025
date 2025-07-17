using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class Listing : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public Listing(int duration)
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
        { 
            
        }

        public override void RunActivity()
        {
            DisplayStartingMessage();

            var rand = new Random();
            Typewriter.Print("\nPrompt:");
            Typewriter.Print($"--- {_prompts[rand.Next(_prompts.Count)]} ---\n");

            Typewriter.Print($"You have {_duration} seconds. Start listing:");
            var items = new List<string>();
            var endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }

            Typewriter.Print($"\nYou listed {items.Count} items. Nice work!");
            DisplayEndingMessage();
        }
    }
}