public class Pattern7
{
    public void PrintPattern(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int k = i; k >= 1; k--)
            {
                System.Console.Write(k);
            }
            System.Console.WriteLine();
        }
    }
}