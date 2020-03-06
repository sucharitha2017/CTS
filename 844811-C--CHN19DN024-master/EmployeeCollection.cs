using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCollection
{
    class EmployeeCollection
    {
        List<Employee> LstEmp = new List<Employee>();


        public  void AddEmp()
        {
            Employee e = new Employee();

            Console.WriteLine("Enter ID : ");
            e.Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            e.Ename = Console.ReadLine();
            Console.WriteLine("Enter Designation : ");
            e.Designation = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            e.Salary = double.Parse(Console.ReadLine());

            LstEmp.Add(e);
        }

        public  void show()
        {
            foreach(Employee e in LstEmp)
            {
                Console.WriteLine("{0},{1},{2},{3}", e.Eid, e.Ename, e.Designation, e.Salary);
            }
        }
        public void RemoveEmp(int Index)
        {
            LstEmp.RemoveAt(Index);
            show();
        }
    }
}
