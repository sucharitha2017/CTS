using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Train : Roadway
    {
        public void showtrain()
        {
            Console.WriteLine("From Train");
        }
        public override void Show()
        {
            Console.WriteLine("Train track is perfect");
        }
    }
}
