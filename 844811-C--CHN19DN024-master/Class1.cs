using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Class1
    {
        string firstname;
        string lastname;
        string name;
        string idno;
        string course;
        DateTime joindate;

        public Class1()
        {
        }
        public Class1(string fn, string ln)
        {
        }
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }
        public string Idno
        {
            get { return idno; }
            set { idno = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime Joindate
        {
            set { joindate = value; }
            get { return joindate; }
        }
    }
}
