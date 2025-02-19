public class Swimming : Activity
{
    // attributes
    private double _laps;
    // constructor
    public Swimming(double laps, double length) : base(length)
    {
        _laps = laps;
    }
    // methods
    public override double GetDistance()
    {
        double distance = _laps * 50/1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = GetDistance()/GetLength() * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60/GetSpeed();
        return pace;
    }
}