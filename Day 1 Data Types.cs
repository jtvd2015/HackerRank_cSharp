using System;
using System.Collections.Generic;
using System.IO;

internal class Solution
{
    private static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int a = Convert.ToInt32(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        string l = Console.ReadLine();

        Console.WriteLine(a + i);
        Console.WriteLine((d + x).ToString("#.0"));
        Console.WriteLine(s + l);

        Console.ReadKey();
    }
}