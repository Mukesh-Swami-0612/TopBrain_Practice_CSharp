using System;

public class Program
{
    public static void checkHeight(int h)
    {
        if (h == -1)
        {
            Console.WriteLine("Thanks");
            return;
        }
        else
        {
            if (h < 150)
            {
                Console.WriteLine("Short height");
            }
            else if (h >= 150 && h <= 180)
            {
                Console.WriteLine("Average Height");
            }
            else
            {
                Console.WriteLine("Tall height");
            }
        }

        int hNew = int.Parse(Console.ReadLine());
        checkHeight(hNew);
    }

    public static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        checkHeight(h);
    }
}
