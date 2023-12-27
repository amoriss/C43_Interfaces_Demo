using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_Interfaces_Demo;
public interface IFlyable
{
    public int FlightSpeed { get; set; }
    public void Fly(); // stubbed out method
}
