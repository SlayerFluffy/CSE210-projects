public class ChecklistGoal: Goal
{
    //Attributes
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    //Constructors
    public ChecklistGoal(string name, string description, string points,int target, int bonus): base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    //Methods
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }
    public override bool IsComplete()
    {
        bool complete = false;
        if (_amountCompleted >= _target)
        {
            complete = true;
        }
        return complete;
    }
    public override string GetDetailsString()
    {
        // get reader friendly goal details
        string details = $"Goal name: {_shortName}\nDescription: {_description}\nPoints: {_points}\nBonus for completion: {_bonus}\nAmount Completed: {_amountCompleted}/{_target}";
        return details;
    }
    public override string GetStringRepresentation()
    {
        // get goal details in a file friendly format
        string details = $"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}";
        return details;
    }
}