public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;
    //Constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, string points, bool complete) : base(name, description, points)
    {
        _isComplete = complete;
    }
    //Methods
    public override void RecordEvent()
    {
        _isComplete = true;
        // send _points to GoalManager _score

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // get goal details in a file friendly format
        string details = $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";
        return details;
    }
}