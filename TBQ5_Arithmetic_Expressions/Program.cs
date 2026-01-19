using System;

public class Solution
{
    public static string EvaluateExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 3)
            return "Error:InvalidExpression";

        string aStr = parts[0];
        string op = parts[1];
        string bStr = parts[2];

        if (!int.TryParse(aStr, out int a) || !int.TryParse(bStr, out int b))
            return "Error:InvalidNumber";

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0) return "Error:DivideByZero";
                return (a / b).ToString(); 

            default:
                return "Error:UnknownOperator";
        }
    }


    public static void Main()
    {
        Console.WriteLine(EvaluateExpression("10 + 5"));  
        Console.WriteLine(EvaluateExpression("10 / 0"));   
        Console.WriteLine(EvaluateExpression("a + 5"));    
        Console.WriteLine(EvaluateExpression("10 ^ 2"));   
        Console.WriteLine(EvaluateExpression("10+5"));     
    }
}
