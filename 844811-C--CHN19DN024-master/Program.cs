using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Values
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b = 99;
			short s = 113;
			Console.WriteLine("The byte value {0} is in the range of 0 to 255",b);
			Console.WriteLine("The short value {0} is in the range of 0 to 359", s);
			Console.ReadKey();

		}
	}
}
