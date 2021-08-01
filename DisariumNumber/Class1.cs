using System;
using System.Linq;

public class Kata
{
    public static string DisariumNumber(int number)
    {
        var sumOfPowers = number.ToString()
            .Select((ch, idx) => (int)Math.Pow(int.Parse(ch.ToString()), idx + 1))
            .Aggregate(0, (acc, curr) => acc + curr);
        return sumOfPowers == number ? "Disarium !!" : "Not !!";
    }
}