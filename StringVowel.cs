using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class Program
	{
		/*
		static void printvowels(string s,int i)
		{
			if (i == s.Length)
				return;
			if(s[i]=='a' || s[i]=='e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'|| s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' )
				Console.WriteLine(s[i]);
			printvowels(s, ++i);
		}
		*/
		static void printvowels(string s, int i)
		{
			string vowel = "aeiouAEIOU";
			if (i == s.Length)
				return;
			if (vowel.Contains(s[i].ToString()))
				Console.WriteLine(s[i]);
			printvowels(s, ++i);
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter string");
			string s = Console.ReadLine();
			int i = 0;
			printvowels(s,i);
		}
	}
}
