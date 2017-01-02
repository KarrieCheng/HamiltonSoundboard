using System;
using System.Collections.Generic;

namespace Hamilton.PCL
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