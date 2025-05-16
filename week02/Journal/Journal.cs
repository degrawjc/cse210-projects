using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Journal
{
public List<Entry> _entries = new List<Entry>();
public void AddEntry()//Entry newEntry)
{
    //Good
    Entry entry = new Entry();
    PromptGenerator prompt = new PromptGenerator();
    entry._promptText = prompt.GetRandomPrompt();
    Console.WriteLine(entry._promptText);
    Console.Write("> ");
    entry._entryText = Console.ReadLine();
    //Good

    _entries.Add(entry);
    foreach (Entry ent in _entries)
    {
        ent.Display();
    }
}
public void DisplayAll()
{
    Entry display1 = new Entry();
    display1.Display();
}
public void SaveToFile(string file)
{

Console.WriteLine("What is the filename?");
Console.Write("");
file = Console.ReadLine();
using (StreamWriter outputFile = new StreamWriter (file))
{
    outputFile.WriteLine($"{file}");
    
}
}
public void LoadFromFile(string file)
{
file = "0";
}
}