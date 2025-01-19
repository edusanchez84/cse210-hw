using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(6);
        Fraction fraction2 = new Fraction(6, 7);

        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());

        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());

        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());

        //changing the values for fraction
        fraction.SetTop(8);
        fraction.SetBottom(9);

        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());

        //getting the decimal and fraction values from here
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionString());

        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());

        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());        
        
    }
}