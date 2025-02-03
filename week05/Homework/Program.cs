using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Ronald Reagan", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Thomas Jefferson", "Percentages", "2", "7");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomework());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Gerald Ford", "Classic English", "The prose and past sentences");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine();
    }
}