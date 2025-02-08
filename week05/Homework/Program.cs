using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment test = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-10");
        string name = test.GetSummary();
        string summary = test.GetHomeworkList();
        Console.WriteLine($"{name}\n{summary}");

        WritingAssignment test2 = new WritingAssignment("John Brown", "Economics", "The Evolution of Capitalism");
        string name2 = test2.GetSummary();
        string summary2 = test2.GetWritingInformation();

        Console.WriteLine($"{name2}\n\n{summary2}");
    }
}