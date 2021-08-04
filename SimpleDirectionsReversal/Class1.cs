using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution
{
    public static string[] solve(string[] arr)
    {
        var expr = @"^(Begin|Left|Right) on (.+)$";

        var directions = arr.Select(item =>
        {
            Match m = Regex.Match(item, expr);

            return m.Groups.Values.ToArray()[1].Value;
        }).ToArray();

        var roadNames = arr.Select(item =>
        {
            Match m = Regex.Match(item, expr);

            return m.Groups.Values.ToArray()[2].Value;
        }).ToArray();

        var result = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            var action = i == 0 ? "Begin" : directions[arr.Length - i] == "Left" ? "Right" : "Left";
            result.Add($"{action} on {roadNames[arr.Length - 1 - i]}");
        }

        return result.ToArray();
    }
}