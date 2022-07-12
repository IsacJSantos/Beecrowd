using System;

class URI
{
    const double PI = 3.14159;
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);
        Calc(a, b, c);
    }
    static void Calc(double A, double B, double C)
    {
        Console.WriteLine($"TRIANGULO: {TriangleArea(A, C).ToString("F3")}");
        Console.WriteLine($"CIRCULO: {CircleArea(C).ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {TrapezeArea(A, B, C).ToString("F3")}");
        Console.WriteLine($"QUADRADO: {SquereArea(B).ToString("F3")}");
        Console.WriteLine($"RETANGULO: {RectangleArea(A, B).ToString("F3")}");
    }

    static double TriangleArea(double b, double h)
    {
        return (b * h) / 2;
    }

    static double CircleArea(double radius)
    {
        return PI * Math.Pow(radius, 2);
    }

    static double TrapezeArea(double B, double b, double h)
    {
        return ((B + b) * h) / 2;
    }

    static double SquereArea(double side)
    {
        return Math.Pow(side, 2);
    }

    static double RectangleArea(double aSide, double bSide)
    {
        return aSide * bSide;
    }
}