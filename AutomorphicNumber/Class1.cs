public class Kata
{
    public static string Automorphic(int n)
    {
        string numberAsString = n.ToString();
        string squareAsString = (n * n).ToString();

        return numberAsString == squareAsString.Substring(squareAsString.Length - numberAsString.Length) ? "Automorphic" : "Not!!";
    }
}