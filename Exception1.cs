using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class Exception1
	{
		static void Main(string[] args)
		{
			int a, b, c;

			Console.WriteLine("Enter a and b");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			try
			{
				c = a / b;
				Console.WriteLine("Res = " + c);
			}
			catch(DivideByZeroException e)
			{
				Console.WriteLine("My exception = "+e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.WriteLine("after c first line");
			Console.WriteLine("after c second line");

		}
	}
}
