using System;

public class Kata
{
    public static int MinSum(int[] a)
    {
        int sum = 0;

        Array.Sort(a);

        for (int i = 0; i < a.Length / 2; i++)
        {
            sum += a[i] * a[a.Length - 1 - i];
        }

        return sum;
    }
}