using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Twelth
    {
        string myName;
        string[] BreakMySentence;
        public Twelth()
        {

        }
        public Twelth(string myName)
        {
            //this.BreakMySentence = BreakMySentence;
            this.myName = myName;
            BreakMySentence = myName.Split('i');
            foreach(string data in BreakMySentence)
            {
                Console.WriteLine("New : {0}",data);
            }
        }

    }
}
