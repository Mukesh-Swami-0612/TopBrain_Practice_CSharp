using System;

class Program
{
    static void Main()
    {
        int feet = 5;

        double centimeters = feet * 30.48;
        double result = Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);

        Console.WriteLine(result);
    }
}
