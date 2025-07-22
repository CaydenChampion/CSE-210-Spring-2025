public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;

    public Event(string title, string description, string date, string time, string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: General\nTitle: {title}\nDate: {date}";
    }

    protected string GetTitle() => title;
    protected string GetDate() => date;
}
