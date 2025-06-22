using System;

public class Program
{
    public static void Main(string[] args)
    {
        Pattern6 pattern = new Pattern6();
        pattern.PrintPattern(5);
        System.Console.WriteLine();

        Pattern7 pattern7 = new Pattern7();
        pattern7.PrintPattern(4);
        System.Console.WriteLine();

        Pattern9 pattern9 = new Pattern9();
        pattern9.PrintPattern(5);
    }
}