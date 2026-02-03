using System;

class Program
{
    public static int SumIntegers(object[] values)
    {
        int sum = 0;

        foreach (object item in values)
        {
            // Pattern matching: check and extract int
            if (item is int x)
            {
                sum += x;
            }
        }

        return sum;
    }

    static void Main()
    {
        object[] values =
        {
            10,
            "Hello",
            20,
            true,
            null,
            5.5,
            30,
            false
        };

        int result = SumIntegers(values);

        Console.WriteLine("Sum = " + result);
    }
}

