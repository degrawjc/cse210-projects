public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToString("d")} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}