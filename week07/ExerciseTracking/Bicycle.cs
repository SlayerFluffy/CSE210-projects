public class Bicycle : Activity
{
    // attributes
    private double _speed;
    // constructor
    public Bicycle(double speed, double length) : base(length)
    {
        _speed = speed;
    }
    // methods
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double distance = _speed/60 * GetLength();
        return distance;
    }

    public override double GetPace()
    {
        double pace = 60/_speed;
        return pace;
    }
}