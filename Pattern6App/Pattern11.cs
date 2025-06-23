public class Pattern11
{
    public void PrintPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= i - 1; k++)
            {
                System.Console.Write(" ");
            }
            for (int j = 1; j <= (2*n) - ((2*i)-1); j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

    }
}