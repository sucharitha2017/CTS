using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    public class Employee
    {
        int id;
        string name, address;
        //Dept dep;
        public Employee()
        {

        }
        public Employee(int i, string nm, string adr)
        {
            id = i;
            name = nm;
            address = adr;
            
        }
        public void show_emp()
        {
           // Console.WriteLine("employee id {0} named as {1} located in {2} and dept {3}", id, name, address, dep.show_dep());
        }
    }
}
