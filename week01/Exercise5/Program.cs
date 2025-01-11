using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorie whole number? ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squaredNum = number * number;
            return squaredNum;
        }

        static void DisplayResults(string name, int squaredNum)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNum}.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNum = SquareNumber(number);
        DisplayResults(name, squareNum);

    }
}