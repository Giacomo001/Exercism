using System;

public static class SimpleCalculator
{
    public static string Calculate(int o1, int o2, string op)
    {
        switch(op) 
        {
            case "+":
                return $"{o1} {op} {o2} = {o1 + o2}";
            case "*":
                return $"{o1} {op} {o2} = {o1 * o2}";
            case "/":
                return o2 != 0 ? $"{o1} {op} {o2} = {o1 / o2}" : "Division by zero is not allowed.";
            case "":
                throw new ArgumentException();
            case null:
                throw new ArgumentNullException();
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
