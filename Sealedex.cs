using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class A
	{
		protected int x;
		public virtual void getx(int a)
		{
			x = a;
		}
	}
	class B:A
	{
		int y;
		public sealed override void getx(int a)
		{
			x = a + 100;
		}
		public void gety(int a)
		{
			y = a;
		}
	}
	class C:B
	{
		int z;
		/*public override void getx(int a)
		{

		}*/
		public void getz(int a)
		{
			z = a;
		}
	}
	class Sealedex
	{
		static void Main(string[] args)
		{
			C ob = new C();
			ob.getz(7);
		}
	}
}
