using System;

class URI
{

    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);
        LargerNumber(a, b, c);
    }
    static void LargerNumber(int A, int B, int C)
    {
        Console.WriteLine(Math.Max(A, Math.Max(B, C)) + " eh o maior");
    }
}