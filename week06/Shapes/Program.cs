using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 5);
        //Console.WriteLine($"Square color: {square1.GetColor()}");
        //Console.WriteLine($"Square area: {square1.GetArea()}");
        Rectangle rec1 = new Rectangle("blue", 5, 6);
        //Console.WriteLine($"Rectangle color: {rec1.GetColor()}");
        //Console.WriteLine($"Rectangle area: {rec1.GetArea()}");
        Circle cir1 = new Circle("yellow", 8);
        //Console.WriteLine($"Circle color: {cir1.GetColor()}");
        //Console.WriteLine($"Circle Area: {cir1.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rec1);
        shapes.Add(cir1);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}