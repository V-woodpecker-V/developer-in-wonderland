using System;

public class Mystery1
{
    public static void Main()
    {
        int[] data = {4, 12, 7, 23, 8, 15};
        int x = 12;
        
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == x)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);
    }
}