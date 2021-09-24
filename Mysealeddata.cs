using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class One
	{
		protected readonly int x ;
		private int y;
		public One()
		{
			Console.WriteLine("Enter the element");
			x = int.Parse(Console.ReadLine());
			x++;
			y = 99;
		}
		void incr()
		{
			y++;
		}
		
	}
	class Two:One
	{
		void increment()
		{
			//x++; this statement will throw error 
		}
	}
	class Mysealeddata
	{
		static void Main(string[] args)
		{
			
		}
	}
}
