public abstract class Goal
{
    //Attributes
    protected string _shortName;
    protected string _description;
    protected string _points;
    public string GetName()
    {
        return _shortName;
    }
    public void SetName(string name)
    {
        _shortName = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }

    //Constructors
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Methods
    public abstract void RecordEvent(); // always override

    public abstract bool IsComplete(); // always override

    public virtual string GetDetailsString()
    {
        string details = $"Goal name: {_shortName}\nDescription: {_description}\nPoints: {_points}\nCompleted: [{(IsComplete() ? 'X' : ' ')}]";
        // code to get details in an easy to read way
        return details;
    }
    public abstract string GetStringRepresentation(); // always override
}