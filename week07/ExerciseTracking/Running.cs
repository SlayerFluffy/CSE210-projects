public class Running : Activity
{ 
    // attributes
    private double _distance;
    // constructor
    public Running(double distance, double length) : base(length)
    {
        _distance = distance;
    }
    // methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance/GetLength() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLength()/_distance;
        return pace;
    }

}