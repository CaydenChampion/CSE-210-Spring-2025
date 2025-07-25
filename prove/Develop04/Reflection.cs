using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class Reflection : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public Reflection(int duration)
            : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.", duration)
        { }

        public override void RunActivity()
        {
            DisplayStartingMessage();

            var rand = new Random();
            Typewriter.Print("\nPrompt:");
            Typewriter.Print($"--- {_prompts[rand.Next(_prompts.Count)]} ---\n");

            int timePerQuestion = _duration / _questions.Count;
            foreach (var question in _questions)
            {
                Typewriter.Print(question);
                PauseWithAnimation(timePerQuestion);
            }

            DisplayEndingMessage();
        }
    }
}

