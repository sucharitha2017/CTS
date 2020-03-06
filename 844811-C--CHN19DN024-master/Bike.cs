using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    public class Bike : IDrone
    {
        public string Bikeno;
        public string Model;
        public string Brand;
        public Bike()
        {

        }
        public Bike(string Bikeno, string Model, string Brand)
        {
            this.Bikeno = Bikeno;
            this.Model = Model;
            this.Brand = Brand;
        }
        public void show()
        {
            Console.WriteLine("{0}", Bikeno);
            Console.WriteLine("{0}", Model);
            Console.WriteLine("{0}", Brand);
        }
    }
}
