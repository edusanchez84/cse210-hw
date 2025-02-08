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
        Random random1 = new Random();
        string fileName = "library.txt";
        string[] linesFile = System.IO.File.ReadAllLines(fileName);
        int fileLines = linesFile.Count();
        int randomLine = random1.Next(fileLines);
        //Console.WriteLine(randomLine);
        string randomLineSel = linesFile[randomLine];
        //Console.WriteLine(randomLineSel);
        string[] newLine = randomLineSel.Split("|");
        string fileHead = newLine[0];
        string fileVerse = newLine[1];
        //Console.WriteLine(fileHead);
        //Console.WriteLine(fileVerse);
        
    }
}