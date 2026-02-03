
using System;

class Program
{
    static string TimeConversion(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        // Format seconds to always be 2 digits
        return minutes + ":" + seconds.ToString("D2");
    }

    static void Main()
    {
        Console.WriteLine(TimeConversion(125)); // 2:05
        Console.WriteLine(TimeConversion(60));  // 1:00
        Console.WriteLine(TimeConversion(9));   // 0:09
    }
}
