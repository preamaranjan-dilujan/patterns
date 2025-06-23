public class Pattern12
{
    public void PrintPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= n - i; k++)
            {
                System.Console.Write(" ");
            }
            for (int j = 1; j <= (2 * i) - 1; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        for (int l = 1; l <= n - 1; l++)
        {
            for (int m = 1; m <= l; m++)
            {
                System.Console.Write(" ");
            }
            for (int j = 1; j <= (2*n)-((2*l)+1); j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        

    }
}