// extra credit: I added another class for bad habit goals. It works similarly to eternal goals where it can't be completed, but everytime 
// an event is recorded it deducts the amount of points from your score.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}