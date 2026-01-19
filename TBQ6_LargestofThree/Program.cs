using System;

public class Program
{
    public static int compare(int a, int b, int c)
    {
        if (a > b)
        {
            if (a > c)
                return a;
            else
                return c;
        }
        else
        {
            if (b > c)
                return b;
            else
                return c;
        }
    }

    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int result = compare(a, b, c);
        Console.WriteLine($"Largest of {a}, {b}, {c} is: {result}");
    }
}
