class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Pasta", "Chef Mario", 300);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Looks delicious!"));
        video1.AddComment(new Comment("Ethan", "Trying this tonight!"));
        videos.Add(video1);

        Video video2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        video2.AddComment(new Comment("Eve", "Very helpful, thanks!"));
        video2.AddComment(new Comment("John", "Can you do one on classes next?"));
        video2.AddComment(new Comment("Tom", "Love the quick tips!"));
        videos.Add(video2);

        Video video3 = new Video("Bike Tricks Compilation", "Trickster", 240);
        video3.AddComment(new Comment("Zoe", "So cool!"));
        video3.AddComment(new Comment("Mike", "I want to try that now"));
        video3.AddComment(new Comment("Liam", "Epic fails at 2:35!"));
        videos.Add(video3);

        Video video4 = new Video("Meditation for Beginners", "Zen Vibes", 900);
        video4.AddComment(new Comment("Sarah", "This calmed me down"));
        video4.AddComment(new Comment("Karen", "Exactly what I needed"));
        video4.AddComment(new Comment("Nick", "Playing this daily now"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
