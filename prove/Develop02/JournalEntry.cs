public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string UserResponse { get; set; }

    public JournalEntry(string date, string prompt, string userResponse)
    {
        Date = date;
        Prompt = prompt;
        UserResponse = userResponse;
    }

    public string GetFileString()
    {
        return $"{Date}~|~{Prompt}~|~{UserResponse}";
    }

    public string GetScreenString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {UserResponse}\n";
    }
}
