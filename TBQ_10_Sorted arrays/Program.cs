using System;
using System.Collections.Generic;

public class Solution
{
    public static T[] MergeSorted<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length, m = b.Length;
        T[] merged = new T[n + m];

        int i = 0, j = 0, k = 0;

        while (i < n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
                merged[k++] = a[i++];
            else
                merged[k++] = b[j++];
        }

        while (i < n) merged[k++] = a[i++];
        while (j < m) merged[k++] = b[j++];

        return merged;
    }
}
