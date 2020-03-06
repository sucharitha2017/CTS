using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovconst
{
    class Test
    {
        string regno;
        string model;
        string color;
        double price;

        public Test()
        {
        }
        public Test(string reg)
        {
            regno = reg;
        }
        public Test(string reg, string mod)
        {
            regno = reg;
            model = mod;
        }
        public Test(string reg, string mod, string color, double pr)
        {
            regno = reg;
            model = mod;
            this.color = color;
            price = pr;
        }
        public void ShowCar()
        {
            Console.WriteLine(regno);
            Console.WriteLine(model);
            Console.WriteLine(color);
            Console.WriteLine(price);

        }
    }
}
