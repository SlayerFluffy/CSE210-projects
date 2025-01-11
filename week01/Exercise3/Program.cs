using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next (1, 15);
        Console.WriteLine("Let's play Magic Number. I'll think of a number and you try to guess it. I'll let you know if you should guess higher or lower.");

        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        } while (guess != number);
    }
}