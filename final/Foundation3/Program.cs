using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture(
            "Tech Innovations 2025", "Explore the latest in AI and robotics.",
            "10/05/2025", "9:00 AM", "123 Tech Lane, Silicon Valley, CA",
            "Dr. Alice Johnson", 150);

        Event reception = new Reception(
            "Startup Launch Party", "Join us to celebrate our new product.",
            "09/15/2025", "6:00 PM", "456 Market St, San Francisco, CA",
            "rsvp@startup.com");

        Event outdoor = new OutdoorGathering(
            "Summer Festival", "A fun-filled day with games, music, and food trucks.",
            "08/01/2025", "12:00 PM", "Central Park, NY",
            "Sunny with a high of 85°F");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("==== Standard Details ====");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\n==== Full Details ====");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\n==== Short Description ====");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n-----------------------------\n");
        }
    }
}
