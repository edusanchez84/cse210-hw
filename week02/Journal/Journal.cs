using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

class Journal
{
    public List<Entry> _entryList = new List<Entry>();
      
    public void DisplayAllEntries()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("Nothing to show yet!");
        }
        else
        {
            Console.WriteLine("Journal Entries");
            foreach (Entry i in _entryList)
            {
                i.Display();
            }
        }
    }

    public void AddEntry(string promptText, string entryText)
    {
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        Entry newEntry = new Entry (date, promptText, entryText);
        _entryList.Add(newEntry);
    }

    public void SaveToFile(List<Entry> _entryList)
    {
        Console.WriteLine("What is the filename? please end the filename with the extension '.json'");
        string filename = Console.ReadLine();
        
        string jsonString = JsonSerializer.Serialize(_entryList);
        File.WriteAllText(filename, jsonString);
        Console.WriteLine("The file has been saved.");
        
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename? remember to add the extension '.json' to the end of the filename");
        string filename = Console.ReadLine();

        // Read JSON from the file
        string jsonString = File.ReadAllText(filename);

        // Deserialize the JSON back into a list
        var entryList = JsonSerializer.Deserialize<List<Entry>>(jsonString);

        if (entryList != null)
        {
            foreach (Entry i in entryList)
            {
                Entry newEntry = new Entry (i.Date, i.PromptText, i.EntryText);
                _entryList.Add(newEntry);
            }
            Console.WriteLine("The file has been loaded. Select option 2 to view the journal.");
        }
        else
        {
            Console.WriteLine("The file is empty or contains invalid data.");
        }
       
    }   
}