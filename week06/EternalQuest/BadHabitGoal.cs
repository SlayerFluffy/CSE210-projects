using System.Diagnostics;

public class BadHabitGoal: Goal
{
    // attributes
    int _amountCompleted = 0;
    // constructors
    public BadHabitGoal(string name, string description, string penalty): base(name, description, penalty)
    {
    }

    // methods
    public override void RecordEvent()
    {
        // record the event
        _amountCompleted ++;
    }
    public override bool IsComplete()
    {
        // check if the goal is complete
        return false;
    }
    public override string GetStringRepresentation()
    {
        // get goal details in a file friendly format
        string details = $"BadHabitGoal~{_shortName}~{_description}~{_points}~{_amountCompleted}";
        return details;
    }
}