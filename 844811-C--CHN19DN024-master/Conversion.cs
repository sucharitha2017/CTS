using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Conversion
    {
        double cmm;
        double INches;
        public Tuple<double,double> Inches(double inches)
        {
            double cm = 0;
            cmm = cm;
            INches = inches;
            
            if (cm > 0)
            {
                cm = 2.54 * inches;
            }
            else
            {
                new Exception("Enter greater than 0");
            }
            return Tuple.Create(cm, inches);
        }
        public void display()
        {
            Console.WriteLine("{0}\n{1}",cmm, INches);
        }


    }
}
