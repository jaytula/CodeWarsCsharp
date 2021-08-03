using System;

public class Funcij
{

	public static ulong sumin(ulong n)
	{
		if (n == 0) return 0;
		if (n == 1) return 1;
		return (ulong)Math.Pow(n, 2) + sumin(n - 1);
	}
	public static ulong sumax(ulong n)
	{
		return (ulong)Math.Pow(n, 3) - sumin(n - 1);
	}
	public static ulong sumsum(ulong n)
	{
		return sumin(n) + sumax(n);
	}
}