using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    class Cid
    {

        public string Cname;
        public int cid;
        Description Price;
        public Cid()
        {

        }
        public Cid(string Cname, int cid, Description Price)
        {
            this.Cname = Cname;
            this.cid = cid;
            this.Price = Price;
        }
        public void display()
        {
            Console.WriteLine("name is {0} with id {1} costs {2}", Cname, cid, Price);
        }
        
    }
}
