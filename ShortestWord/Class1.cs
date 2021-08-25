using System.Linq;

public class Kata
{
    public static int FindShort(string s)
    {
        return s.Split(' ').Select(word => word.Length).Min();
    }
}