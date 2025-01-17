// A class template for objects known as Job. 
// Responsible for holding and displaying names for company and job title, and years for start and end. 
using System.Security.Cryptography.X509Certificates;

public class Job
{
    // variables
    public string _companyName = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    
    // methods
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}