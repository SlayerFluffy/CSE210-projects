public class Shape
{
    //attributes
    private string _color;

    //constructor
    public Shape(string color)
    {
        _color = color;
    }

    //methods
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }
}

