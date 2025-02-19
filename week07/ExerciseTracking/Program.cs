using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(4.8, 30));
        activities.Add(new Bicycle(16, 20));
        activities.Add(new Swimming(20, 45));
        foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

    }
}