using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Calculate
    {
        public string area(double r)
        {
            double ar = Math.PI * r * r;
            return string.Format("Area of circle = {0}", ar);
        }
        public string area(double b, int h)
        {
            double ar = 0.5 * b * h;
            return string.Format("Area of Triangle = {0}", ar);
        }
        public string area(double b, double l)
        {
            double ar = l * b;
            return string.Format("Area of Reactangle = {0}", ar);
        }

    }
}
