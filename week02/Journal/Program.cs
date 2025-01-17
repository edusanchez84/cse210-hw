//Notes about the additional features added
//1. In the Journal class when the option "2. Display" is selected there is an if loop to check if there is information
//   to display, if there is not a message pops up, if possitive the behaviour continues.
//2. In the Journal class there are confirmation messages added when the "savetofile" and "loadtofile" process finishes.
//3. In Main menu there is an additional feature on the loop, in case a wrong number or data is recieved a try again is 
//   requested and loops back to the menu.
//4. The file is saved in .json format and recovered from that format also.


using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        PromptGenerator prompt1 = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompt1.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                
                
                case "2":
                    journal.DisplayAllEntries();
                    break;
                
                
                case "3":
                    journal.LoadFromFile();
                    break;
                
                
                case "4":
                    journal.SaveToFile(journal._entryList);
                    break;
                
                
                case "5":
                    Console.WriteLine("See you next time!");
                    return;
                
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
            }
        }

    }
}