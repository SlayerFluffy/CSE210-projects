// class template for objects called WritingAssignment
// child class of Assignment object
// stores values for topic and title of Writing Assignments
// can return an assignment summary

public class WritingAssignment : Assignment
{
    //Attributes
    private string _title;

    //constructor
    public WritingAssignment(string name, string topic, string title): base(name, topic)
    {
        _title = title;
    }

    //Method
    public string GetWritingInformation()
    {
        string summary = $"\"{_title}\" by {_name}";
        return summary;
    }
}