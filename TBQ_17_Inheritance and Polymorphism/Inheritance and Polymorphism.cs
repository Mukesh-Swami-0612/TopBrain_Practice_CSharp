using System;
using System.Collections.Generic;

abstract class Employee
{
    public abstract decimal GetPay();
}

class HourlyEmployee : Employee
{
    decimal rate, hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal GetPay()
    {
        return rate * hours;
    }
}

class SalariedEmployee : Employee
{
    decimal salary;

    public SalariedEmployee(decimal salary)
    {
        this.salary = salary;
    }

    public override decimal GetPay()
    {
        return salary;
    }
}

class CommissionEmployee : Employee
{
    decimal commission, baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal GetPay()
    {
        return baseSalary + commission;
    }
}

class Solution
{
    public static decimal TotalPayroll(string[] employees)
    {
        decimal total = 0;

        foreach (string emp in employees)
        {
            string[] parts = emp.Split(' ');
            Employee e = null;

            if (parts[0] == "H")
                e = new HourlyEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));
            else if (parts[0] == "S")
                e = new SalariedEmployee(decimal.Parse(parts[1]));
            else if (parts[0] == "C")
                e = new CommissionEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));

            total += e.GetPay();
        }

        return Math.Round(total, 2);
    }
}
