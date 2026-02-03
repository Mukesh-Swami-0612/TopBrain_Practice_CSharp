
using System;
using System.Collections.Generic;

class Program
{
    public static int GetTotalSalary(
        Dictionary<int, int> empSalary,
        int[] ids)
    {
        int total = 0;

        foreach (int id in ids)
        {
            // Check if ID exists in dictionary
            if (empSalary.ContainsKey(id))
            {
                total += empSalary[id];
            }
        }

        return total;
    }

    static void Main()
    {
        // Dictionary: EmployeeId -> Salary
        Dictionary<int, int> empSalary = new Dictionary<int, int>()
        {
            { 1, 20000 },
            { 4, 40000 },
            { 5, 15000 }
        };

        // List of Employee IDs
        int[] ids = { 1, 4, 5 };

        int result = GetTotalSalary(empSalary, ids);

        Console.WriteLine(result); // 75000
    }
}
