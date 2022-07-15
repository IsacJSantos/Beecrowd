using System;

class URI
{
    const int KML = 12;
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int avrSpeed = int.Parse(Console.ReadLine());
        Calc(hours, avrSpeed);
    }

    static void Calc(int hours, int avrSpeed)
    {
        double distance = hours * avrSpeed;
        Console.WriteLine((distance / KML).ToString("F3"));
    }

}
