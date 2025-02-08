using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        List<string> _prompts = 
        [
            "-- Who are people that you appreciate? --",
            "-- What are personal strengths of yours? --",
            "-- Who are people that you have helped this week? --",
            "-- When have you felt the Holy Ghost this month? --",
            "-- Who are some of your personal heroes? --"
        ];
        
        Random random1 = new Random();
        List<int> randomLines = [0, 1, 3, 4];
        int randomLine = random1.Next(_prompts.Count());
        
        Console.WriteLine(randomLine);

        //List<int> randomlines = [];
        //int displayPrompLine = GetRandomPrompt();
        while (randomLines.Contains(randomLine))
        {
            Console.WriteLine("Numero Repetido");
            randomLine = random1.Next(_prompts.Count());
            
        }
        Console.WriteLine($"Verificado {randomLine}");
        //Console.WriteLine(randomLine);
        

    }
}