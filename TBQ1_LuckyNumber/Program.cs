using System;

class Program
{
    static int SumDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (IsPrime(x)) continue;   

            int s1 = SumDigits(x);
            int square = x * x;
            int s2 = SumDigits(square);

            if (s2 == s1 * s1)
                count++;
        }

        Console.WriteLine(count);
    }
}
