// a class template for the objects known as Resume.
// responsible for holding and displaying name of owner of resume and a list of their jobs from the class Job

public class Resume
{
    // variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job instance in _jobs)
        {
            instance.Display();
        }
    }
    
}