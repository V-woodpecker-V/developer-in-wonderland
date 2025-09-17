using System;

public class FunctionExamples
{
    public static int AddCoffees(int morningCup, int afternoonCup)
    {
        return morningCup + afternoonCup;
    }
    
    public static void Main()
    {
        Console.WriteLine(AddCoffees(5, 3));
    }
}