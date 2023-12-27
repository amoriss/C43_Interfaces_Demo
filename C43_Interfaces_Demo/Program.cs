namespace C43_Interfaces_Demo;

internal class Program
{
    static void Main(string[] args)
    {
        Plane plane1 = new Plane();
        plane1.FlightSpeed = 500;

        Superman superman1 = new Superman();
        superman1.FlightSpeed = 501;

        List<IFlyable> list = new List<IFlyable>();
        list.Add(plane1);
        list.Add(superman1);

        foreach (IFlyable item in list)
        {
            item.Fly();
            Console.WriteLine($"Flight Speed: {item.FlightSpeed}");
            Console.WriteLine();
        }
    }
}
