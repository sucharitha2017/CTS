using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Ship : Vehicle
    {
        public void Showship()
        {
            Console.WriteLine("From ship");
        }
        new public void ShowVehicle()
        {
            Console.WriteLine("Cruise liner ship");
        }
    }
}
