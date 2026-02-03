using System;
using System.Globalization;

class Solution
{
    public static double ComputeTotalArea(string[] shapes)
    {
        double total = 0;

        foreach (string s in shapes)
        {
            if (string.IsNullOrWhiteSpace(s))
                continue;

            string[] parts = s.Split(' ');
            char type = parts[0][0];

            Shape shape = null;

            switch (type)
            {
                case 'C':
                    double r = double.Parse(parts[1]);
                    shape = new Circle(r);
                    break;

                case 'R':
                    double w = double.Parse(parts[1]);
                    double h = double.Parse(parts[2]);
                    shape = new Rectangle(w, h);
                    break;

                case 'T':
                    double b = double.Parse(parts[1]);
                    double th = double.Parse(parts[2]);
                    shape = new Triangle(b, th);
                    break;
            }

            if (shape != null)
                total += shape.GetArea();
        }

        // Round to 2 decimals AwayFromZero
        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    static void Main()
    {
        string[] shapes =
        {
            "C 3",
            "R 4 5",
            "T 6 2"
        };

        Console.WriteLine(ComputeTotalArea(shapes));
    }
}
