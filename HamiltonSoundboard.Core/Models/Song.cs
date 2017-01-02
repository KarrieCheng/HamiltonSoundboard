using System;
using System.Collections.Generic;

namespace HamiltonSoundboard.Core
{
	public class Song
	{
		public Song()
		{
		}
		public String Name { get; set; }
		public int Act { get; set; }
		public List<string> Characters { get; set; }
	}
}