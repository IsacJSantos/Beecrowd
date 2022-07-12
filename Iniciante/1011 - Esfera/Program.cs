using System; 

class URI {
    const double PI = 3.14159;
    static void Main(string[] args) { 
        double r = double.Parse(Console.ReadLine());
        SphereVolume(r);
    }

    static void SphereVolume(double radius){
        double volume = (4.0/3.0) * PI * Math.Pow(radius,3);
        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
    }
}