using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    class Description
    {
        public int Pid;
        public string Pname;
        public double Price;
        public Description()
        {

        }
        public Description(string Pname, double Price, int Pid)
        {
            this.Pid = Pid;
            this.Pname = Pname;
            this.Price = Price;
        }
    }
}
