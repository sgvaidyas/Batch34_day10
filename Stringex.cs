using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class Stringex
	{
		void string_ex1()
		{
			string s1 = "Apple";
			string s2 = "Mango";
			string s3 = "Grapes";
			string s4;
			s4 = string.Concat(s1, s2, s3);
			Console.WriteLine(s4);


			string a, b;

			a = "hey this is me";
			b = "hey";
			Console.WriteLine(a.Contains(b));

			a = "apple";
			b = a;
			Console.WriteLine(a, " : ", b);

			a = null;
			Console.WriteLine(b);

			char[] x = new char[] { 'a', 'p', 'p', 'l', 'e' };
			string s5 = new string(x);

			Console.WriteLine(s5);

			string s6 = "Watsup!!!hey there ???";
			char[] ch = new char[20];

			s6.CopyTo(6, ch, 0, 15);
			Console.WriteLine(ch);//!!!hey there ??

		}
		void endswithfun()
		{
			Console.WriteLine("enter string");
			string s = Console.ReadLine();
			string s1 = "ies";
			Console.WriteLine(s.EndsWith(s1));

		}
		void referencedemo()
		{

			string a = "apple";
			string b = a;
			//string a = Console.ReadLine();
			//string b = Console.ReadLine();
			unsafe
			{
				fixed (char* x = a)
				{
					x[0] = 'H';
				}
			}
			Console.WriteLine(a);
			Console.WriteLine(b);

			Console.WriteLine("a==b" + a == b);
			Console.WriteLine(" equals = " + a.Equals(b));
		}
		void formatting()
		{
			int age = 11;
			float sal = 8000;
			string name = "pavan";

			string s = string.Format("{0} is earning {1} at the age of {2}", name, sal, age);
			Console.WriteLine(s);

		}
		void getenummeth()
		{
			string s = "hey this is another example";

			CharEnumerator ch = s.GetEnumerator();

			while (ch.MoveNext())
			{
				Console.WriteLine(ch.Current);
			}
		}
		void indexofmeth()
		{
			string a, b, c;
			a = "hey this is csharp";
			b = "csharp";
			c = "ada";
			Console.WriteLine(a.IndexOf(b));//12 found at 12th index
			Console.WriteLine(a.IndexOf(c));//-1 : not found
		}

		void joinmeth()
		{
			string[] a = new string[] { "hi", "this", "is", "me" };

			string s1 = string.Join("                  ", a);

			Console.WriteLine(s1);
		}
		void padding_meth()
		{
			string s = "hey hope you had tea";

			Console.WriteLine(s.PadLeft(30));

			Console.WriteLine(s.PadRight(30) + "___________________");
		}
		void upperlower()
		{
			string a = "hi there??";

			Console.WriteLine(a.ToUpper());
			Console.WriteLine(a);

			string b = "HI WHAT'S special";
			Console.WriteLine(b.ToLower());

		}

		void isupperfun()
		{
			string a = "hI hoW are You 8907 hjghj";

			for (int i = 0; i < a.Length; i++)
			{
				if (Char.IsUpper(a[i]))
					Console.WriteLine(a[i]);
			}

			for (int i = 0; i < a.Length; i++)
			{
				if (Char.IsDigit(a[i]))
					Console.WriteLine(a[i]);
			}
		}



		static void Main(string[] args)
		{
			
		}
	}
	
}
