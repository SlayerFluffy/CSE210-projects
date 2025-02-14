public class EternalGoal : Goal
{
    //Attributes
    int _amountCompleted = 0;
    //Constructors
    public EternalGoal(string name, string description, string points): base(name, description, points)
    {
    }

    //Methods
    public override void RecordEvent()
    {
        // send _points to GoalManager _score
        _amountCompleted ++;
    }
    public override bool IsComplete()
    {
        bool complete = false;
        return complete;
    }
    public override string GetStringRepresentation()
    {
        // get goal details in a file friendly format
        string details = $"EternalGoal~{_shortName}~{_description}~{_points}~{_amountCompleted}";
        return details;
    }
}