using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Eleven
    {
        string str1;
        string str2;
        
        public Eleven()
        {

        }
        public Eleven(string str1,string str2)
        {
            this.str1 = str1;
            this.str2 = str2;
            //strconcat = str3;
            string strconcat = string.Concat(str1, str2);
            Console.WriteLine("Full name : ", strconcat);
        }
        //public void show()
       // {
        //    Console.WriteLine("Full name : ",strconcat);
       // }
    }
}
