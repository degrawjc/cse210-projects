using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;

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
    _entries.Add(entry);
}
public void DisplayAll()
{
    //Good
    foreach (Entry ent in _entries)
    {
        ent.Display();
    }
}
public void SaveToFile()
{
    Console.WriteLine("What is the filename?");
    Console.Write("");
    string file = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter (file))
    {
        foreach(Entry ent in _entries)
        {
            outputFile.WriteLine($"{ent._date}~~{ent._promptText}~~{ent._entryText}");
        }
    }
}
public void LoadFromFile()
{
    Console.WriteLine("What is the filename?");
    Console.Write("");
    string file = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(file);
    foreach (string line in lines)
    {
        Entry entry = new Entry();
        string[] parts = line.Split("~~");
        entry._date = DateTime.Parse(parts[0]);
        entry._promptText = parts[1];
        entry._entryText = parts[2];
        _entries.Add(entry);
    }
}
}