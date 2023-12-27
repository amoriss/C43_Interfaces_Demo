using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_Interfaces_Demo;
public class Plane : StuffInSky, IFlyable
{
    public int FlightSpeed { get; set; }

    public void Fly()
    {
        Console.WriteLine("Plane is flying.");
    }
}
