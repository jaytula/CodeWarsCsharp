using System;
using System.Collections.Generic;
public class Kata
{
    public static int[] OrArrays(int[] arr1, int[] arr2, int d = 0)
    {
        int length = Math.Max(arr1.Length, arr2.Length);
        List<int> result = new List<int> { };
        
        for(int i = 0; i < length; i++)
        {
            int val1 = i >= arr1.Length ? d : arr1[i];
            int val2 = i >= arr2.Length ? d : arr2[i];
            result.Add(val1 | val2);
        }
        return result.ToArray();
    }
}