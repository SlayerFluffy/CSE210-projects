using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Enter 0 when finished.");
        List<int> numbers = new List<int>();
        string input = "";

        do
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }
            int addNumber = int.Parse(input);
            numbers.Add(addNumber);
        } while (input != "0");

        Console.WriteLine($"Sum of the numbers is: {numbers.Sum()}");
        Console.WriteLine($"Average of the numbers is: {numbers.Average()}");
        Console.WriteLine($"Largest number is is: {numbers.Max()}");
    }
}