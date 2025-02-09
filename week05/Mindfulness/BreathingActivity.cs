using System;
using System.IO;
//class template for BreathingActivity object. Child of Activity class.
public class BreathingActivity : Activity
{
    //attributes

    //constructor
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.";
    }

    //method
    public void Run()
    // set a timer and count down on a new thread. print breath in and breath out with sleep delays until finished.
    {
        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (currentTime < endTime)
        {
            Console.Write("Breathe in... \n");
            ShowCountDown(5);
            Console.Write("Breathe out...\n");
            ShowCountDown(5);
            currentTime = DateTime.Now;
            if (currentTime >= endTime) break;
        }
    }
}
