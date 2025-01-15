using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

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
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry i in _entryList)
                {
                    outputFile.WriteLine($"{i._date}|{i._promptText}|{i._entryText}");
                }
        }
        Console.WriteLine("The file has been saved.");
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string readFile = Console.ReadLine();
        
        using (StreamReader reader = new StreamReader(readFile))
        {
            string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split("|");
                        //parts[0] - _date
                        //parts[1] - _promptText
                        //parts[2] - _entryText

                        string date = parts [0];
                        string promptText = parts[1];
                        string entryText = parts[2];

                        Entry newEntry = new Entry(date, promptText, entryText);
                        _entryList.Add(newEntry);
                        
                    }
            
        }
        Console.WriteLine("The file has been loaded, select 2 to view the journal");
    }   
}