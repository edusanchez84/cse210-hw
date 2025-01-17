using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


class Entry
{
    [JsonPropertyName("_date")]
    public string Date { get; set; }

    [JsonPropertyName("_promptText")]
    public string PromptText { get; set; }

    [JsonPropertyName("_entryText")]
    public string EntryText { get; set; }

    // Default constructor for deserialization
    public Entry() 
    {
        
    }

    // Constructor for manual creation
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    
    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}");
        Console.WriteLine("");
    }
}