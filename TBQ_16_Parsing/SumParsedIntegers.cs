using System;
public static class SumParsedIntegers
{
    public static int Sum(string[] tokens)
    {
        if (tokens == null) return 0;

        int sum = 0;
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int value))
                sum += value;
        }
        return sum;
    }

    public static void Main()
    {
        string[] tokens = { "1", "2", "abc", "3", "999999999999", "4" };
        Console.WriteLine(Sum(tokens)); // 1+2+3+4 = 10
    }
}
