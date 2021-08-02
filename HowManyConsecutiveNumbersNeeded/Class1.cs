using System;
public class Kata
{
    public static int Consecutive(int[] arr)
    {
        if (arr.Length < 2) return 0;

        Array.Sort(arr);

        return arr[arr.Length - 1] - arr[0] + 1 - arr.Length;
    }
}