//As additional features for Showing Creativity and Exceeding Requirements I have done these:
//The program work with a library of scriptures rather than a single one, this library can be 
//extended or reduced and the program will still work as long as the formatting of the added scriptures is keept. 
//Also the program load the scripture at random from a .txt file.

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {   
        Random random1 = new Random();
        string fileName = "library.txt";
        string[] linesFile = System.IO.File.ReadAllLines(fileName);
        int totalLines = linesFile.Count();
        int randomLine = random1.Next(totalLines);
        string randomLineSelected = linesFile[randomLine];
        string[] selected = randomLineSelected.Split("|");
        string fileHead = selected[0];
        string fileVerse = selected[1];
        
        Scripture scripture = new Scripture();
        List<Word> randomList = new List<Word>();
        
        Console.WriteLine();
        scripture.GetDisplayText(fileHead, fileVerse);

        while (true)
        {    
            Console.WriteLine();  
            Console.WriteLine("Please type enter to continue, or type 'quit' to finish:");
            string answer = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            
            switch(answer)
            {
                case "":

                    scripture.HideRandomWords(randomList, fileHead);
                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine();
                        Console.WriteLine("Congratulations, you have memorized this scripture!");
                        return;
                    }
                    break;
                
                case "quit":
                
                    return;
            }
        }
    }               
    
}