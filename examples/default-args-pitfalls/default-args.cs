using System;
using System.Collections.Generic;

public class DefaultArgs
{
    public static List<int> CollectNumbers(int n, List<int> result = null)
    {
        if (result == null) result = new List<int>();
        
        if (n <= 0)
            return result;
        
        result.Add(n);
        return CollectNumbers(n - 1, result);
    }
    
    public static void Main()
    {
        Console.WriteLine("First call: [" + string.Join(", ", CollectNumbers(3)) + "]");
        Console.WriteLine("Second call: [" + string.Join(", ", CollectNumbers(2)) + "]");
        Console.WriteLine("Third call: [" + string.Join(", ", CollectNumbers(4)) + "]");
    }
}