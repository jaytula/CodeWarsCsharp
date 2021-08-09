using System.Linq;
using System.Collections.Generic;
public static class Kata
{
    public static int[] ArrayLeaders(int[] numbers)
    {
        List<int> result = new List<int> { };

        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers.Skip(i + 1).Sum()) result.Add(numbers[i]);
        }
        return result.ToArray();
    }
}