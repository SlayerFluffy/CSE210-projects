using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");

        Fraction fraction2 = new Fraction(2);
        Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");

        Fraction fraction3 = new Fraction(2,4);
        Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()}");

        Console.WriteLine("Give a new numberator: ");
        string t = Console.ReadLine();
        int Top = int.Parse(t);
         Console.WriteLine("Give a new denominator: ");
        string b = Console.ReadLine();
        int Bottom = int.Parse(b);
        fraction1.SetTop(Top);
        fraction1.SetBottom(Bottom);
        Console.WriteLine($"The numberator is {fraction1.GetTop()} and the denominator is {fraction1.GetBottom()}");

        Console.WriteLine($"String of new fraction is {fraction1.GetFractionString()}");
        Console.WriteLine($"The decimal of new fraction is {fraction1.GetDecimalValue()}");
    }
}