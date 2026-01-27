using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Age;
    public int Marks;

    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }
}

class StudentComparer : IComparer<Student>
{
    public int Compare(Student a, Student b)
    {
        if (a.Marks != b.Marks)
            return b.Marks.CompareTo(a.Marks); // Highest Marks first

        return a.Age.CompareTo(b.Age); // Youngest first
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Amit", 21, 90),
            new Student("Ravi", 19, 90),
            new Student("Neha", 20, 85)
        };

        students.Sort(new StudentComparer());

        foreach (var s in students)
            Console.WriteLine($"{s.Name} {s.Age} {s.Marks}");
    }
}
