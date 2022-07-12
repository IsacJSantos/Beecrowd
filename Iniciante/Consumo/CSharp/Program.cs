using System;

class URI
{
    static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine());
        double gas = double.Parse(Console.ReadLine());
        Consumption(km, gas);
    }

    static void Consumption(int km, double gas)
    {
        Console.WriteLine((km / gas).ToString("F3") + " km/l");
    }

}