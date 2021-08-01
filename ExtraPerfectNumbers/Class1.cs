using System;
using System.Collections.Generic;

public class Kata
{
    public static int[] ExtraPerfect(int n)
    {
        List<int> result = new List<int>();
        for (int i = 1; i <= n; i += 2)
        {
            result.Add(i);
        }
        return result.ToArray();
    }
}