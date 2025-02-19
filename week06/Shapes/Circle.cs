public class Circle: Shape
{
    //attributes
    private double _radius;
    //constructor
    public Circle(string color, double radius): base( color)
    {
        _radius = radius;
    }
    //methods
    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
}