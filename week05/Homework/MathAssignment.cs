// class template for objects called MathAssignment.
// child class of Assignment.
// requires same info as assignment class and additionally, stores
// textbook section and problems as strings. 

public class MathAssignment : Assignment
{
    // attributes
    private string _section;
    private string _problems;

    // constructor
    public MathAssignment(string name, string topic, string section, string problems): base(name, topic)
    {
        _section = section;
        _problems = problems;
    }

    // methods
    public string GetHomeworkList()
    {       
        string HomeworkList = $"Section: {_section} Problems: {_problems}";
        return HomeworkList;
    }
}