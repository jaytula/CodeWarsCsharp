using System.Text.RegularExpressions;

public static class Kata
{
    public static string Doubles(string str)
    {
        Regex rx = new Regex(@"(aa|bb|cc|dd|ee|ff|gg|hh|ii|jj|kk|ll|mm|nn|oo|pp|qq|rr|ss|tt|uu|vv|ww|xx|yy|zz)");

        while(rx.Match(str).Success)
        {
            str = rx.Replace(str, "");
        }
        return str;
    }
}