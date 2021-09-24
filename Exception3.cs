using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class Exception3
	{
		static void Main(string[] args)
		{
			string[] s = new string[] { "apple", null, "mango", null,"jjjj" };

			foreach (string x in s)
			{
				try
				{
					Console.WriteLine(x +" : " +x.Length);
				}
				catch (NullReferenceException e)
				{
					Console.WriteLine("NULL VALUE");
				}
			}			
		}
	}
}
