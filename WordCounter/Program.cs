﻿class Program
{
    public static void Main(string[] args)
    {
        WordCounter wordCounter = new WordCounter("This is a test sentence.");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("test");
        Console.WriteLine(count);
    }
}