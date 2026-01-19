using System;
using System.Collections.Generic;
using System.Text.Json;

public record Student(string Name, int Score);

public class Program
{
    public static string GetStudentsJson(string[] items, int minScore)
    {
        List<Student> students = new List<Student>(items.Length);

        foreach (string item in items)
        {
            int colonIndex = item.LastIndexOf(':');
            if (colonIndex <= 0 || colonIndex == item.Length - 1) 
                continue;

            string name = item.Substring(0, colonIndex);

            if (!int.TryParse(item.Substring(colonIndex + 1), out int score))
                continue;

            if (score >= minScore)
                students.Add(new Student(name, score));
        }

        students.Sort((s1, s2) =>
        {
            int scoreCompare = s2.Score.CompareTo(s1.Score); // Descending Score
            if (scoreCompare != 0) return scoreCompare;

            return string.Compare(s1.Name, s2.Name, StringComparison.Ordinal); // Ascending Name
        });

        return JsonSerializer.Serialize(students);
    }

    public static void Main()
    {
        string[] items = { "Mukesh:90", "Anish:90", "Jeevan:70", "Prashant:95" };
        int minScore = 80;

        string json = GetStudentsJson(items, minScore);
        Console.WriteLine(json);
    }
}
