using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class Enumexampless
	{
		enum Days { Mon, Tue, Wed, Thu=50, Fri, Sat, Sun };
		static void Main(string[] args)
		{
			Console.WriteLine(Days.Fri);
			Console.WriteLine((int)Days.Fri);


			foreach(int i in Enum.GetValues(typeof(Days)))
			{
				Console.WriteLine(i);
			}

			foreach (string i in Enum.GetNames(typeof(Days)))
			{
				Console.WriteLine(i);
			}
		}
	}
}
