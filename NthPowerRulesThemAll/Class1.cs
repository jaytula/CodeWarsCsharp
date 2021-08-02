using System;
using System.Linq;

public class Kata
{
    public static int ModifiedSum(int[] a, int n)
    {
        return a.Select(val => (int)Math.Pow(val, n)).Sum() - a.Sum();
    }
}