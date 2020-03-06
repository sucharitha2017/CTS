using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    public class Dept
    {
        int id;
        string D_name;
        public Dept()
        {

        }
        public Dept(int i, string nm)
        {
            id = i;
            D_name = nm;
        }
        public void show_dep()
        {
            Console.WriteLine("Dept id is {0} and named as {1}", id, D_name);
        }
    }
}
