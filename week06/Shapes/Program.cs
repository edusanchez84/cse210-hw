using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Blue", 2.5);
        //Console.WriteLine($"The Square color is {square1.GetColor()} and the area is: {square1.GetArea()}");
        
        Rectangle rectangle1 = new Rectangle("Red", 3, 2);
        //Console.WriteLine($"The Rectangle color is {rectangle1.GetColor()} and the area is: {rectangle1.GetArea()}");

        Circle circle1 = new Circle("Green", 3);
        //Console.WriteLine($"The Circle color is {circle1.GetColor()} and the area is: {circle1.GetArea()}");

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shapes s in shapes)
        {
            Console.WriteLine($"The Shape color is {s.GetColor()} and the area is: {s.GetArea()}");
        }
        
    }
}