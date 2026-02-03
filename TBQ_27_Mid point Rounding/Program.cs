
using System;

class Program
{
    public static double GetCircleArea(double radius)
    {
        // Calculate area
        double area = Math.PI * radius * radius;

        // Round to 2 decimals (AwayFromZero)
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }

    static void Main()
    {
        double r = 5.5;

        double result = GetCircleArea(r);

        Console.WriteLine(result);
    }
}
