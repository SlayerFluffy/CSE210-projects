// class template
public abstract class Activity
{
    // attributes
    private string _date;
    private double _length;
    public double GetLength()
    {
        return _length;
    }
    // constructor
    public Activity(double length)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _length = length;
    }
    // methods
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        string activityType = this.GetType().Name;
        string summary = $"{_date} {activityType} - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
        return summary;
    }
}