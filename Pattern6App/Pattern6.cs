public class Pattern6
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
    }
}