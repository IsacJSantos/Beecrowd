using System;

class URI
{

    static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine());
        Resolution(km);
    }

    static void Resolution(int km)
    {
        Console.WriteLine($"{km * 2} minutos");
    }

}