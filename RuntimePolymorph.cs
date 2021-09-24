using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
	class MusicPlayers
	{
		public virtual  void play()
		{
			Console.WriteLine("Music player is playing");
		}
	}

	class VLC:MusicPlayers
	{
		public override void play()
		{
			Console.WriteLine("VLC is playing ");
		}
	}
	class WMP : MusicPlayers
	{
		public override void play()
		{
			Console.WriteLine("WMP is playing ");
		}
	}
	class RuntimePolymorph
	{
		static void Main(string[] args)
		{
			MusicPlayers ob = new VLC();
			ob.play();
			MusicPlayers ob1 = new WMP();
			ob1.play();
		}
	}
}
