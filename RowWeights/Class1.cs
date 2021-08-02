public class Kata
{
    public static int[] RowWeights(int[] a)
    {
        int teamOneWeight = 0;
        int teamTwoWeight = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (i % 2 == 0) teamOneWeight += a[i];
            else teamTwoWeight += a[i];
        }

        return new int[] { teamOneWeight, teamTwoWeight };
    }
}