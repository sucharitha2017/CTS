using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    class BikeDrone : Bike,IDrone
    {
        public BikeDrone()
        {

        }
        public BikeDrone(string Brand)
        {
            this.Brand = Brand;
        }
        new void show()
        {
            Console.WriteLine("{0}", Brand);
            Console.WriteLine("It works on road and air");
        }
    }
}
