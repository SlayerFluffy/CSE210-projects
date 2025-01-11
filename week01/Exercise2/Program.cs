using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage?: ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if ( percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80 && percent < 90)
        {
            letter = "B";
        }
        else if (percent >= 70 && percent < 80)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (percent >= 70)
        {
            Console.WriteLine($"Your grade is {letter} Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter} You've failed, better luck next time!");
        }
    }
}