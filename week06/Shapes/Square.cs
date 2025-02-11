using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    //attributes
    private double _side;
    //constructor
    public Square(string color, double side): base(color)
    {
        _side = side;
    }
    //methods
    public override double GetArea()
    {
        double area = _side * 2;
        return area;
    }
}