using System;

public class Solution
{
    public static int SumPositiveUntilZero(int[] nums)
    {
        long sum = 0;

        foreach (int x in nums)
        {
            if (x == 0) break;       // stop
            if (x < 0) continue;     // ignore negatives
            sum += x;                // add positives
        }

        return (int)sum;
    }
}
