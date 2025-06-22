public class Pattern9
{
    public void PrintPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= i; k++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        for (int i = n-1; i >= 1; i--)
        {
            for (int k = i; k >= 1; k--)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}