using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptkey
{
    class Excpt
    {
        public Excpt()
        {

        }
        public Excpt(int a, int b)
        {
            int x = a / b;
            if(b == 0)
            {
                throw new NullReferenceException("LOOOOOOOOOOOOOOOOOOOOOOOL");
            }
        }
    }
}
