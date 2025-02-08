// template for Assignment class objects.
// will hold basic universal values for child classes that are also assignments.

public class Assignment
{
    // Attributes
    protected string _name;
    private string _topic;

    // Constructor
    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    // Methods
    public string GetSummary()
    {
        string name_and_topic = $"{_name} - {_topic}";
        return name_and_topic;
    }
}