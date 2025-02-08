using System;
using System.Collections;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity reflectingActivity1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    breathingActivity1.DisplayStartingMessage();
                    breathingActivity1.Run();
                    breathingActivity1.DisplayEndingMessage();
                    break;

                case 2:
                    reflectingActivity1.DisplayStartingMessage();
                    reflectingActivity1.Run();
                    reflectingActivity1.DisplayEndingMessage();
                    break;

                case 3:
                    listingActivity1.DisplayStartingMessage();
                    listingActivity1.Run();
                    listingActivity1.DisplayEndingMessage();
                    break;
                
                default :
                    return;
            }
        }

    }
}