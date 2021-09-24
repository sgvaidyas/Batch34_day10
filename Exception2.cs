using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class Exception2
	{
		static void Main(string[] args)
		{
			int[] a = new int[] { 77, 55, 66, 77, 44, 77, 99 };

			Console.WriteLine("Enter the index = ");
			int ind = int.Parse(Console.ReadLine());
			try
			{
				Console.WriteLine("you have won " + a[ind] + " lucky coupon");
			}
			catch(IndexOutOfRangeException e)
			{
				Console.WriteLine(e.Message);
			}


			Console.WriteLine("after c first line");
			Console.WriteLine("after c second line");
		}
	}
}
